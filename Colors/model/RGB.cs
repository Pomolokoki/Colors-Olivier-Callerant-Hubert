using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Media;

namespace Colors.model
{
    /// <summary>
    /// A color written with RGB components
    /// </summary>    
    public class RGB : IColorMode
    {
        #region code not to edit
        private readonly float red;
        private readonly float green;
        private readonly float blue;

        /// <summary>
        /// Create a RGB Color
        /// </summary>
        /// <param name="r">red value (0-255)</param>
        /// <param name="g">green value (0-255)</param>
        /// <param name="b">blue value (0-255)</param>
        /// <exception cref="BadColorValues">If values are not correct</exception>
        public RGB(float r, float g, float b)
        {
            if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
                throw new BadColorValues();
            red = r;
            green = g;
            blue = b;
        }

        /// <summary>
        /// Gets the red value
        /// </summary>
        public int Red
        {
            get { return (int)red; }
        }

        /// <summary>
        /// Return the green value
        /// </summary>
        public int Green
        {
            get { return (int)green; }
        }

        /// <summary>
        /// return the blue value
        /// </summary>
        public int Blue
        {
            get { return (int)blue; }
        }

        /// <summary>
        /// Gets the color in 32-bits value
        /// </summary>
        public Int32 Int
        {
            get
            {
                return (Red << 16) | (Green << 8) | Blue;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is RGB rGB &&
                   Int == rGB.Int;
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert the color in RGB
        /// </summary>
        /// <returns>the same color with RGB components</returns>
        public RGB ToRGB()
        {
            return this;
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
