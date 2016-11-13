using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace EdgeAplication
{
    public partial class MainPanel : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Business business;


        public MainPanel()
        {
            InitializeComponent();
            business = new Business();
           

        }

        private void loadImgButton_Click(object sender, EventArgs e)
        {
            originalBitmap = business.loadImg();
            previewBitmap = business.refreshDisplayedImg(originalBitmap,pictureBox.Width) ;
            pictureBox.Image = previewBitmap;
            msgLabel.Text = "Image loaded.";
        }

        private void applyEdgeButton_Click(object sender, EventArgs e)
        {
            previewBitmap = business.refreshDisplayedImg(business.ApplyEdge(originalBitmap), pictureBox.Width);
            pictureBox.Image = previewBitmap;
            msgLabel.Text = "Edge applied.";
        }

        private void saveImgButton_Click(object sender, EventArgs e)
        {
            business.saveImg(previewBitmap);
            msgLabel.Text = "Image has been saved.";
        }
    }
}
