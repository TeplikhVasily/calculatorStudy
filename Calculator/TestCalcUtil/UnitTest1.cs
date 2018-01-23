using ConsoleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCalcUtil
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {

            //arrange
            var x = 10;
            var y = 1;
            var calc = new Calculate();

            //act
            var result = calc.Sum(x, y);

            //assert
            Assert.AreEqual(result, 11);

        }
        [TestMethod]
        public void TestSub()
        {

            //arrange
            var x = 10;
            var y = 1;
            var calc = new Calculate();

            //act
            var result = calc.Sub(x, y);

            //assert
            Assert.AreEqual(result, 9);

        }
        [TestMethod]
        public void TestMul()
        {

            //arrange
            var x = 10;
            var y = 2;
            var calc = new Calculate();

            //act
            var result = calc.Mul(x, y);

            //assert
            Assert.AreEqual(result, 20);

        }
        [TestMethod]
        public void TestDiv()
        {

            //arrange
            var x = 10;
            var y = 0;
            var calc = new Calculate();

            //act
            var result = calc.Div(x, y);

            //assert
            Assert.AreEqual(result, double.PositiveInfinity);

        }
    }
}
