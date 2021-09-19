using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawCanvas.Test
{
    [TestClass]
    public class Canvas_Test
    {
        //[TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod()]
        public void Test_CreateCanvas_Positive()
        {
            int x = 20;
            int y = 20;

            Canvas canvas = null;

            try
            {
                canvas = new Canvas(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Assert.IsNotNull(canvas, "Canvas got created with invalid co ordinates.");

        }

        [TestMethod()]
        public void Test_CreateCanvas_Negative()
        {
            int x = -1;
            int y = 0;

            Canvas canvas = null;

            try
            {
                canvas = new Canvas(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Assert.IsNull(canvas, "Canvas is not created with correct co ordinates.");

        }
    }
}
