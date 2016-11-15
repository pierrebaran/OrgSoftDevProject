using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Drawing;
using NSubstitute;
using EdgeAplication;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class MainTests
    {
        /*
         * -- Testing the utilitaries --
         */
        [TestCategory("UtilitariesTest"), TestMethod()]
        public void testBmpEqualTrue()
        {
            StreamReader streamReader = new StreamReader("..\\..\\Ressources\\Cobra.jpg");
            //initialise original bitmap
            Bitmap b1 = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            Bitmap b2 = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();

            Assert.IsTrue(Utilitaries.bmpEqual(b1, b2));
        }

        [TestCategory("UtilitariesTest"),TestMethod()]
        public void testBmpEqualFalse()
        {
            StreamReader streamReader = new StreamReader("..\\..\\Ressources\\Cobra.jpg");
            //initialise original bitmap
            Bitmap b1 = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader = new StreamReader("..\\..\\Ressources\\Rattlesnake.jpg");
            Bitmap b2 = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();

            Assert.IsFalse(Utilitaries.bmpEqual(b1, b2));
        }

        /*
         *  -- Tests of the image Handler --
         *
         * Testing a nominal case
         */
        [TestCategory("BusinessTest"), TestMethod()]
        public void nominalApplyEdge() {
            Bitmap bmp = new Bitmap("..\\..\\Ressources\\Cobra.jpg");
            BusinessInterface b = new Business();
           
            Bitmap bmp2 = b.ApplyEdge(bmp);
            Assert.IsFalse(Utilitaries.bmpEqual(bmp, bmp2));
        }

      





    }
}
