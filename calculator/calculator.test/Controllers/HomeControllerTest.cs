using System;
using NUnit.Framework;
using calculator.Controllers;
namespace calculator.test.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void sumTest_twoPositiveNumbers()
        {
            //arrange
            int n1 = 3;
            int n2 = 5;
            int expected = 8;
            HomeController hc = new HomeController();
            //act
            int result = hc.sum(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be positive");
        }
        [Test]
        public void sumTest_twoNegativeNumbers()
        {
            //arrange
            int n1 = -3;
            int n2 = -5;
            int expected = -8;
            HomeController hc = new HomeController();
            //act
            int result = hc.sum(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be negative");
        }
        [Test]
        public void sumTest_oneNegativeNumber()
        {
            //arrange
            int n1 = 3;
            int n2 = -5;
            int expected = -2;
            HomeController hc = new HomeController();
            //act
            int result = hc.sum(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be negative");
        }
        //mult
        [Test]
        public void multTest_twoPositiveNumbers()
        {
            //arrange
            int n1 = 3;
            int n2 = 5;
            int expected = 15;
            HomeController hc = new HomeController();
            //act
            int result = hc.mult(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be positive");
        }
        [Test]
        public void multTest_oneNegativeNumber()
        {
            //arrange
            int n1 = -3;
            int n2 = 5;
            int expected = -15;
            HomeController hc = new HomeController();
            //act
            int result = hc.mult(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be negative");
        }
        [Test]
        public void multTest_twoNegativeNumber()
        {
            //arrange
            int n1 = -3;
            int n2 = -5;
            int expected = 15;
            HomeController hc = new HomeController();
            //act
            int result = hc.mult(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be positive");
        }
        [Test]
        public void multTest_oneNumberEqualsZero()
        {
            //arrange
            int n1 = 3;
            int n2 = 0;
            int expected = 0;
            HomeController hc = new HomeController();
            //act
            int result = hc.mult(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be zero");
        }
        //div
        [Test]
        public void divTest_twoPositiveNumbers()
        {
            //arrange
            int n1 = 4;
            int n2 = 2;
            int expected = 2;
            HomeController hc = new HomeController();
            //act
            int result = hc.div(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be positive");
        }
        [Test]
        public void divTest_twoNegativesNumbers()
        {
            //arrange
            int n1 = -4;
            int n2 = -2;
            int expected = 2;
            HomeController hc = new HomeController();
            //act
            int result = hc.div(n1, n2);
            //assert
            Assert.AreEqual(expected, result, 0.0001, "result should be positive");
        }
        [Test]
        public void divTest_divisionOnZeroNumber()
        {
            //arrange
            int n1 = 4;
            int n2 = 0;
            HomeController hc = new HomeController();
            //act and assert
            Assert.Throws<DivideByZeroException>(new TestDelegate(() => hc.div(n1,n2)));
        }

    }
}
