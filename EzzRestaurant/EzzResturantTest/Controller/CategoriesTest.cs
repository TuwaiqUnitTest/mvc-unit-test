using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzzRestaurant.Controllers;
using EzzRestaurant.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace EzzResturantTest.Controller
{
    [TestFixture]
   public class CategoriesTest
    {
        [Test]
        public void Index_Action_ViewData_NotNull()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Index() as ViewResult;

            //Assert
            Assert.NotNull(result.ViewData["Categories"]);
        }
        
        [Test]
        public void Index_Action_ViewData_IsCategoryList()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Index() as ViewResult;
            List<CategoryModel> categ = (List<CategoryModel>) result.ViewData["Categories"];

            //Assert
            Assert.IsInstanceOf(typeof(List<CategoryModel>) , categ);
        }
        
        [Test]
        public void Index_Action_IndexView()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index" , result.ViewName);
        }


        [Test]
        public void Details_Action_CategorySearchFound()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(2) as ViewResult;
            CategoryModel category = (CategoryModel) result.ViewData["Category"];

            //Assert
            Assert.AreEqual(2, category.Id);
        }

        [Test]
        public void Details_Action_ViewData_IsCategory()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(2) as ViewResult;
            CategoryModel categ = (CategoryModel)result.ViewData["Category"];

            //Assert
            Assert.IsInstanceOf(typeof(CategoryModel), categ);
        }

        [Test]
        public void Details_Action_CategorySearchNotFound()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(12) as ViewResult;
            

            //Assert
            Assert.Null(result.ViewData["Category"]);
        }
        


        //Product Data Test , we will test with case not found and found
        // id 12 => Not Exist
        // id 1 => Exist
        [Test]
        public void Details_Action_ProductsSearchNotFound()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(12) as ViewResult;
            var products = (List<ProductModel>) result.ViewData["Products"];

            //Assert
            Assert.AreEqual(0 , products.Count);
        }
        
        [Test]
        public void Details_Action_ProductsSearchFound()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(1) as ViewResult;
            var products = (List<ProductModel>) result.ViewData["Products"];

            //Assert
            Assert.Greater(products.Count, 0);
        }

        [Test]
        public void Details_Action_ViewData_IsProductList()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(2) as ViewResult;

            // Assert
            Assert.IsInstanceOf(typeof(List<ProductModel>), result.ViewData["Products"]);
        }

        [Test]
        public void Details_Action_ProductsView()
        {
            //Arrange
            CategoriesController categories = new CategoriesController();

            //Act
            ViewResult result = categories.Products(1) as ViewResult;

            //Assert
            Assert.AreEqual("Products" , result.ViewName);
        }


    }
}
