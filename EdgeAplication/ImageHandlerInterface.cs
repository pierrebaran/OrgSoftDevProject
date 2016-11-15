using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeAplication
{
    public interface ImageHandlerInterface
    {
        void saveImg(Bitmap finalBmp);
        Bitmap loadImg();
        Bitmap refreshDisplayedImg(Bitmap sourceBitmap, int canvasWidthLenght);
    }
}
