﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Framed.Extensions
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Parse a string of format #AARRGGBB into a Color.
        /// </summary>
        public static Color Parse(string v)
        {
            string hex = v.Substring(1); // Trim off the #
            byte a = Byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte r = Byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = Byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            if (v.Length == 9)
            {
                byte b = Byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                return Color.FromArgb(a, r, g, b);
            }
            else
            {
                return Color.FromArgb(1, a, r, g);
            }
        }

        public static string ToString(this Color c, bool useAlpha)
        {
            string s = c.ToString();

            if (useAlpha)
            {
                return "#" + s.Substring(3);
            }

            return s;
        }
    }
}
