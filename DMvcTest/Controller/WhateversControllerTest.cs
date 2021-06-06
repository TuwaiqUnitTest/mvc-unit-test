using NUnit.Framework;
using DMvc.Controllers;
using System;

namespace DMvcTest
{
    public class Tests
    {
       

        [Test]
        
        public void squareRootOfpositiveTest() // Square Root function, Positive input test 
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
            double test1 = controllerOBJ.squareRoot(4); // positive input , output expected = 2          
            //Assert
            Assert.AreEqual(2, test1);           
           
        }
        [Test]
        public void squareRootOfZeroTest() // Square Root function, Zero input test 
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
            double test2 = controllerOBJ.squareRoot(0); // Zero , output expected = 0

            //Assert
            Assert.AreEqual(0, test2);


        }
        [Test]
        public void squareRootTest()  // Square Root function, Negative input test 
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();

            //Assert
            Assert.Throws<Exception>(() => controllerOBJ.squareRoot(-4));   // negative input , output expected= Exception

        }
        [Test]
        public void divSameSignsTest()
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
            double test1 = controllerOBJ.div(4,4); //divide positive inputs , output expected = 1
            //Assert
            Assert.AreEqual(1, test1);
         
        }
        [Test]
        public void divDifferentSignsTest()
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
            double test2 = controllerOBJ.div(4, -4); // divide by negative number , output expected = -1
            //Assert
            Assert.AreEqual(-1, test2);
        }
        [Test]
        public void divByZeroTest()
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
           
            //Assert 
            Assert.Throws<Exception>(() => controllerOBJ.div(4, 0));     // divide by Zero , output expected = Throw Exception
           
        }
        [Test]
        public void sumOfPositivesTest() // SUM function test , two  
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
            float test1 = controllerOBJ.sum(4, 2); // Two positive inputs, output expected = 6
            //Assert
            Assert.AreEqual(6, test1); 
        }
        [Test]
        public void sumOfPositiveAndNegativeTest() // SUM function test, Different signs input 
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
            float test2 = controllerOBJ.sum(4, -2); // Posite and negative inputs , output expected = 2
           //Assert
            Assert.AreEqual(2, test2);
           
        }
        [Test]
        public void sumOfNegativesTest() // SUM function test 
        {
            //Arange
            WhateversController controllerOBJ = new WhateversController();
            //Act
        
            float test3 = controllerOBJ.sum(-4, -2); // two negative inputs , output expected = -6
            //Assert
           
            Assert.AreEqual(-6, test3);
        }
    }
}