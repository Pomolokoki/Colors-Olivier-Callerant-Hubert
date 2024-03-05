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
            throw new NotImplementedException();
        }
        /// <summary>
        /// Convert the color in HSL
        /// </summary>
        /// <returns>The color with HSL components</returns>
        public HSL ToHSL()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert the color in standard WPF color format
        /// </summary>
        /// <returns>the color in standard WPF color format</returns>
        public Color ToColor()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
