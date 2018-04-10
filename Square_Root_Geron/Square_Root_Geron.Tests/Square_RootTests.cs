using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Square_Root_Geron.Tests
{
    [TestClass]
    public class Square_RootTests
    {
        [TestMethod]
        public void Square_256_5_4()
        {
            //arrange
            double x = 256.2144566;
            int k = 5;
            double expected = Math.Sqrt(x);
            double delta = 0.0003;

            //act
            Square_Root a = new Square_Root();
            double actual = a.Formula_Gerona(x, k);

            //assert
            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Square_256_5_2()
        {
            double x = 256.2144566;
            int k = 5;
            double expected = Math.Sqrt(x);
            double delta = 0.01;

            Square_Root a = new Square_Root();
            double actual = a.Formula_Gerona(x, k);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Square_256_5_5()
        {
            double x = 256.2144566;
            int k = 5;
            double expected = Math.Sqrt(x);
            double delta = 0.0000001;

            Square_Root a = new Square_Root();
            double actual = a.Formula_Gerona(x, k);

            Assert.AreEqual(expected, actual, delta);
        }
    }
}
