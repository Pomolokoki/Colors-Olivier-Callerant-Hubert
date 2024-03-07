using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Text;

namespace Colors.model
{
    /// <summary>
    /// A color in HTML format (a simple String)
    /// </summary>
    public class HTML : IColorMode
    {
        #region do not edit
        private string htmlCode;

        /// <summary>
        /// Initialize the color with HTML value like #FF80C0 (RRGGBB in hexa)
        /// </summary>
        /// <param name="value">value the html code of the color</param>
        /// <exception cref="BadColorValues">If string format is not correct</exception>
        public HTML(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new BadColorValues();
            try
            {
                if (value[0] != '#')
                    throw new BadColorValues();
                int test = Int32.Parse(value.Substring(1), System.Globalization.NumberStyles.HexNumber);
                // if not thrown, then the value is ok
				htmlCode = value;
            }
            catch
            {
                throw new BadColorValues();
            }

        }

        public override string ToString()
        {
            return htmlCode;
        }

        public override bool Equals(object obj)
        {
            return obj is HTML hTML &&
                   htmlCode == hTML.htmlCode;
        }
        #endregion

        #region code to do
        /// <summary>
        /// Convert the color in CMJN
        /// </summary>
        /// <returns>The same color with CMJN components</returns>
        public CMYB ToCMYB()
        {
            try
            {
                if (htmlCode[0] != '#' || htmlCode.Length != 7)
                {
                    throw new BadColorValues();
                }

                int red = Convert.ToInt32(htmlCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(htmlCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(htmlCode.Substring(5, 2), 16);

                float c = 1.0f - (red / 255.0f);
                float m = 1.0f - (green / 255.0f);
                float y = 1.0f - (blue / 255.0f);
                float k = Math.Min(c, Math.Min(m, y));

                return new CMYB(c, m, y, k);
            }
            catch
            {
                throw new BadColorValues();

            }
        }
        /// <summary>
        /// Convert the color in HSL
        /// </summary>
        /// <returns>The color with HSL components</returns>
        public HSL ToHSL()
        {
            try
            {
                // Assurez-vous que le code hexadécimal est dans un format valide
                if (htmlCode[0] != '#' || htmlCode.Length != 7)
                {
                    throw new BadColorValues();
                }

                // Extraire les composants Rouge, Vert et Bleu du code hexadécimal
                int red = Convert.ToInt32(htmlCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(htmlCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(htmlCode.Substring(5, 2), 16);

                // Normaliser les composants RGB pour les convertir en valeurs HSL
                float r = red / 255.0f;
                float g = green / 255.0f;
                float b = blue / 255.0f;

                float max = Math.Max(r, Math.Max(g, b));
                float min = Math.Min(r, Math.Min(g, b));

                float h, s, l;

                // Calcul de la luminance (lightness)
                l = (max + min) / 2.0f;

                // Calcul de la saturation
                if (max == min)
                {
                    h = s = 0; // Achromatic
                }
                else
                {
                    float d = max - min;
                    s = l > 0.5f ? d / (2.0f - max - min) : d / (max + min);

                    // Calcul de la teinte (hue)
                    if (max == r)
                        h = (g - b) / d + (g < b ? 6.0f : 0.0f);
                    else if (max == g)
                        h = (b - r) / d + 2.0f;
                    else
                        h = (r - g) / d + 4.0f;

                    h /= 6.0f;
                }

                return new HSL(h, s, l);
            }
            catch
            {
                throw new BadColorValues();
            }
        }
        /// <summary>
        /// Convert the color in HTML
        /// </summary>
        /// <returns>the color in HTML string format</returns>
        public HTML ToHTML()
        {
            return this;
        }

        /// <summary>
        /// Convert the color in RGB
        /// </summary>
        /// <returns>the same color with RGB components</returns>
        public RGB ToRGB()
        {
            try
            {
                if (htmlCode[0] != '#' || htmlCode.Length != 7)
                {
                    throw new BadColorValues();
                }

                int red = Convert.ToInt32(htmlCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(htmlCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(htmlCode.Substring(5, 2), 16);

                return new RGB(red, green, blue);
            }
            catch
            {
                throw new BadColorValues();
            }
        }

        /// <summary>
        /// Convert the color in standard WPF color format
        /// </summary>
        /// <returns>the color in standard WPF color format</returns>
        public Color ToColor()
        {
            try
            {
                if (htmlCode[0] != '#' || htmlCode.Length != 7)
                {
                    throw new BadColorValues();
                }

                int red = Convert.ToInt32(htmlCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(htmlCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(htmlCode.Substring(5, 2), 16);

                return Color.FromRgb((byte)red, (byte)green, (byte)blue);
            }
            catch
            {
                throw new BadColorValues();
            }
        }

        #endregion

    }
}
