using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Drawing;
using NSubstitute;
using EdgeAplication;

namespace UnitTests
{
    [TestClass]
    public class MainTests
    {
        /*
         * We'll first test our utilaries method used later in the tests to confirm they work correctly
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
         * 
         */
        [TestCategory("ImageHandlerTest"), TestMethod()]
        public void nominalImageLoading() {

            var substituteHandler = Substitute.For<ImageHandlerInterface>();
            Bitmap bmp = new Bitmap("..\\..\\Ressources\\Cobra.jpg");
           

            Assert.IsTrue(Utilitaries.bmpEqual(bmp, bmp));



        } 

    }
}
