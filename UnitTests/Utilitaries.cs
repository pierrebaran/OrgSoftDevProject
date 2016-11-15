using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{

    public static class Utilitaries
    {
        
        /*
         * This method compares 2 bitmaps pixel by pixel and returns if they're equal
         */ 
        public static Boolean bmpEqual(Bitmap b1, Bitmap b2)
        {
            Boolean result = true;

            if (b1.Width != b2.Width)
                return false;
            if (b1.Height != b2.Height)
                return false;

            for (int i = 0; i < b1.Width; i++)
            {
                for (int j = 0; j < b1.Height; j++)
                {
                    Color cb1 = b1.GetPixel(i, j);
                    Color cb2 = b2.GetPixel(i, j);

                    if ((cb1.A != cb2.A) || (cb1.R != cb2.R) || (cb1.G != cb2.G) || (cb1.B != cb2.B))
                        return false;
                }
            }
            return result;
        }
    }
}
