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
        Bitmap ApplyEdge(Bitmap sourceBitmap);
        Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix);
    }
}
