using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeAplication
{
    public interface BusinessInterface
    {
        Bitmap loadImg();
        Bitmap refreshDisplayedImg(Bitmap sourceBitmap, int canvasWidthLenght);
        Bitmap ApplyEdge(Bitmap sourceBitmap);
        Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0, bool grayscale = false);
        void saveImg(Bitmap finalBmp);


    }
}
