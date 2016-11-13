using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeAplication
{
    public interface ImageHandlerInterface
    {
        void saveImg(Bitmap finalBmp);
        Bitmap loadImg();
        Bitmap refreshDisplayedImg(Bitmap sourceBitmap, int canvasWidthLenght);
    }
}
