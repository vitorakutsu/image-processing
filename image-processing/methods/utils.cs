using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_processing.methods
{
    internal class Utils
    {
        public static bool isBlack (Color color)
        {
            return color.A == 255 && color.R == 0 && color.G == 0 && color.B == 0;
        }

        public static bool isWhite (Color color)
        {
            return color.A == 255 && color.R == 255 && color.G == 255 && color.B == 255;
        }
    }
}
