using System;
using NUnit.Framework;
using Calculator.Controllers;


namespace CalculatorTest
{
    public class CalculatorControllerTest
    {
        CalculatorController calc = new();

        // AdditionTest
        [Test]
        public void AdditionWithTwoPositiveNumbersTest()
        {
            float res = calc.Addition(2, 40);
            Assert.AreEqual(42, res);
        }

        [Test]
        public void AdditionWithOnePositiveAndOneNegativeNumbersTest()
        {
            float res = calc.Addition(52, -40);
            Assert.AreEqual(12, res);
        }

        [Test]
        public void AdditionWithTwoNegativeNumbersTest()
        {
            float res = calc.Addition(-52, -40);
            Assert.AreEqual(-92, res);
        }

        [Test]
        public void AdditionWithTwoZerosTest()
        {
            float res = calc.Addition(0, 0);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void AdditionWithPositiveNumberAndZeroTest()
        {
            float res = calc.Addition(20, 0);
            Assert.AreEqual(20, res);
        }

        [Test]
        public void AdditionWithNegativeNumberAndZeroTest()
        {
            float res = calc.Addition(-20, 0);
            Assert.AreEqual(-20, res);
        }


        // SubtractionTest
        [Test]
        public void SubtractionWithTwoPositiveNumbersTest()
        {
            float res = calc.Subtraction(2, 40);
            Assert.AreEqual(-38, res);
        }

        [Test]
        public void SubtractionWithOnePositiveAndOneNegativeNumbersTest()
        {
            float res = calc.Subtraction(52, -40);
            Assert.AreEqual(92, res);
        }

        [Test]
        public void SubtractionWithTwoNegativeNumbersTest()
        {
            float res = calc.Subtraction(-52, -40);
            Assert.AreEqual(-12, res);
        }

        [Test]
        public void SubtractionWithTwoZerosTest()
        {
            float res = calc.Subtraction(0, 0);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void SubtractionWithPositiveNumberAndZeroTest()
        {
            float res = calc.Subtraction(20, 0);
            Assert.AreEqual(20, res);
        }

        [Test]
        public void SubtractionWithZeroAndPositiveNumberTest()
        {
            float res = calc.Subtraction(0, 20);
            Assert.AreEqual(-20, res);
        }


        // Multiplication Test

        [Test]
        public void MultiplicationWithTwoPositiveNumbersTest()
        {
            float res = calc.Multiplication(2, 3);
            Assert.AreEqual(6, res);
        }

        [Test]
        public void MultiplicationWithOnePositiveAndOneNegativeNumbersTest()
        {
            float res = calc.Multiplication(2, -3);
            Assert.AreEqual(-6, res);
        }

        [Test]
        public void MultiplicationWithTwoNegativeNumbersTest()
        {
            float res = calc.Multiplication(-2, -3);
            Assert.AreEqual(6, res);
        }

        [Test]
        public void MultiplicationWithTwoZerosTest()
        {
            float res = calc.Multiplication(0, 0);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void MultiplicationWithPositiveNumberAndZeroTest()
        {
            float res = calc.Multiplication(2, 0);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void MultiplicationWithZeroAndPositiveNumberTest()
        {
            float res = calc.Multiplication(0, 3);
            Assert.AreEqual(0, res);
        }


        // Division Test

        [Test]
        public void DivideWithWithTwoPositiveNumbersTest()
        {
            float res = calc.Division(10, 5);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void DivideWithWithOnePositiveAndOneNegativeNumbersTest()
        {
            float res = calc.Division(10, -5);
            Assert.AreEqual(-2, res);
        }

        [Test]
        public void DivideWithTwoNegativeNumbersTest()
        {
            float res = calc.Division(-10, -5);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void DivideByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Division(0,0));
        }
        [Test]
        public void DivideWithZeroAndNumberTest()
        {
            float res = calc.Division(0, 5);
            Assert.AreEqual(0, res);
        }
    }
}