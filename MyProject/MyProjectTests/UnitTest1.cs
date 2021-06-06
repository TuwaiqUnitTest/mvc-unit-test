using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProject.Controllers;
namespace MyProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConcatStringTestMethod()
        {

            var controller = new WelcomeController();
            var actual = controller.ConcatString("Hello ","World");
          
            string  expected = "Hello World";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConcatStringTestMethod_Null_Value()
        {

            var controller = new WelcomeController();
            var actual = controller.ConcatString(null, "World");
            
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SumTestMethod()
        {

            var controller = new WelcomeController();
            var actual = controller.sum(3, 3);

            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void subtractionTestMethod()
        {

            var controller = new WelcomeController();
            var actual = controller.subtraction(3, 3);

            int expected = 0;
            Assert.AreEqual(expected, actual);
        }


    }
}
