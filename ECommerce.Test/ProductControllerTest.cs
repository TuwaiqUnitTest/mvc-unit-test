using ECommerce_ASPNET.Controllers;
using ECommerce_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Test
{
    [TestFixture]
    class ProductControllerTest
    {
        [Test]
        public void Index_ViewDataArrayHasProductsItem()
        {
            ProductsController productsController = new ProductsController();

            ViewResult indexViewResult = productsController.Index() as ViewResult;

            bool hasProductsKey = indexViewResult.ViewData.ContainsKey("Products");

            Assert.IsTrue(hasProductsKey, "There is no key named [Products] in the ViewData array");
        }

        [Test]
        public void Index_ProductsItemTypeInViewDataArrayIsListOfProductModel()
        {
            ProductsController productsController = new ProductsController();

            ViewResult indexViewResult = productsController.Index() as ViewResult;

            bool hasTypeOfProductList = indexViewResult.ViewData["Products"].GetType() == typeof(List<ProductModel>);

            Assert.IsTrue(hasTypeOfProductList, $"Expecting the type to be of [List<ProductModel>] type");
        }

        [Test]
        public void Index_ReturnsAViewNamedIndex()
        {
            ProductsController productsController = new ProductsController();

            ViewResult indexViewResult = productsController.Index() as ViewResult;

            bool viewNameIsIndex = indexViewResult.ViewName == "Index" || indexViewResult.ViewName == null;

            Assert.IsTrue(viewNameIsIndex);
        }

        [Test]
        public void Details_PassIdValueInMinus_ReturnsNotFoundResult()
        {
            ProductsController productsController = new ProductsController();

            var indexViewResult = productsController.Details(-1);

            bool typeIsNotFoundResult = indexViewResult.GetType().Name == "NotFoundResult";

            Assert.IsTrue(typeIsNotFoundResult);
        }

        [Test]
        public void Details_PassZeroAsIdNumber_ReturnsNotFoundResult()
        {
            ProductsController productsController = new ProductsController();

            var indexViewResult = productsController.Details(0);

            bool typeIsNotFoundResult = indexViewResult.GetType().Name == "NotFoundResult";

            Assert.IsTrue(typeIsNotFoundResult);
        }

        [Test]
        public void Details_FetchRecordWhereIdIsEqualOne_ReturnsProductModelInViewDataArray()
        {
            ProductsController productsController = new ProductsController();

            ViewResult result = productsController.Details(1) as ViewResult;

            Assert.IsTrue(result.ViewData.ContainsKey("Product") && (result.ViewData["Product"] as ProductModel).Id == 1);
        }

        [Test]
        public void Details_Pass1000AsIdNumber_ReturnsNotFound()
        {
            ProductsController productsController = new ProductsController();

            var indexViewResult = productsController.Details(1000);

            bool typeIsNotFoundResult = indexViewResult.GetType().Name == "NotFoundResult";

            Assert.IsTrue(typeIsNotFoundResult);
        }

        [Test]
        public void Details_PassAnExistenRecordId_ReturnsAViewNamedDetails()
        {
            ProductsController productsController = new ProductsController();

            ViewResult viewResult = productsController.Details(1) as ViewResult;

            bool viewNameIsDetails = viewResult.ViewName == "Details" || viewResult.ViewName == null;

            Assert.IsTrue(viewNameIsDetails);
        }
    }
}
