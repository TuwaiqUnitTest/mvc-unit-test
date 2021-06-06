using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping.Controllers;

namespace ShoppingTest
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void DoesStringChangerWork()
        {
            //Arrange
            ProductsController controller = new ProductsController();

            //Act
            var result = controller.stringChanger("hi") as ViewResult;

            //Assert
            Assert.AreNotEqual("", result);

        }
    }
}
