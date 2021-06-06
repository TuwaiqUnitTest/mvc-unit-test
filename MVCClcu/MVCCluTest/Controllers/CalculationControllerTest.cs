using NUnit.Framework;
using System;
using MVCClcu.Controllers;
namespace MVCClcu
{

    [TestFixture]
    public class CalculationControllerTest
        //WE used AAA
    {
        [Test]
        public void AddTest()
        {
            int res1, res2;

            //Arange
            CalculationController MathCalculator = new CalculationController();

            //Act
             res1 = MathCalculator.Add(90, 12);
             res2 = MathCalculator.Add(80, 20);

            //Assert
            Assert.AreEqual(102, res1);
            Assert.AreEqual(100, res2);
        }

        [Test]
        public void DivTest()
        {
            int res1, res2;

            //Arange
            CalculationController MathCalculator = new CalculationController();

            //Act
             res1 = MathCalculator.Div(100, 2);
             res2 = MathCalculator.Div(50, 2);

            //Assert
            Assert.AreEqual(50, res1);
            Assert.AreEqual(25, res2);
        }

        [Test]
        public void SubtractTest()
        {
            int res1, res2;
            //Arange
            CalculationController MathCalculator = new CalculationController();

            //Act
             res1 = MathCalculator.Subtract(200, 100);
             res2 = MathCalculator.Subtract(10, 5);

            //Assert
            Assert.AreEqual(100, res1);

            // here we try to make it fail to see so  Expected: 3  But was:  5
            Assert.AreEqual(3, res2);
        }
        [Test]
        public void MulTest()
        {
            int res1, res2;

            //Arange
            CalculationController MathCalculator = new CalculationController();

            //Act
             res1 = MathCalculator.Mul(6, 6);
             res2 = MathCalculator.Mul(10, 10);

            //Assert
            Assert.AreEqual(36, res1);
            Assert.AreEqual(100, res2);
        }
        
        [Test]
        public void DoubleNumber()
        {
            int res;

            //Arange
            CalculationController MathCalculator = new CalculationController();

            //Act
             res = MathCalculator.DoubleNumber(6);

            //Assert
            // here we try to make  it fail so it will be Expected: 50 But was:  36
            Assert.AreEqual(50, res);
        }


        }
    }
