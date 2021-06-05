using NUnit.Framework;
using projectWeek5.Controllers;
using System.Collections.Generic;
using projectWeek5.Models;
using System.Web.Mvc;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace projectWeek5Test
{
    [TestFixture]
    public class Tests
    {
        //Arrange
        RecipesController controllerRecipes = new RecipesController();

        [Test]
        public void Index_TestIndexViewInRecipes()
        {
            //Act
            ViewResult Result = controllerRecipes.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", Result.ViewName);
        }

        [Test]
        public void Details_TestWhereIdIsEqualOneReturnsRecipe()
        {
            //Act
            ViewResult Result = controllerRecipes.Details(1) as ViewResult;

            //Assert
            Assert.IsTrue((Result.ViewData["recipe"] as RecipesModel).recipe_Id == 1);
        }

        [Test]
        public void Index_RecipesTypeInViewDataArrayIsListOfRecipesModel()

        {   //Act
            ViewResult Result = controllerRecipes.Index() as ViewResult;
            //Assert
            Assert.IsTrue(Result.ViewData["Recipes"].GetType() == typeof(List<RecipesModel>));

        }

        //Arrange
        AdminController controllerAdmin = new AdminController();

        [Test]
        public void IndexـTestIndexViewInAdmin()
        {
            //Act
            ViewResult Result = controllerAdmin.Index(1) as ViewResult;

            //Assert
            Assert.AreEqual("Index", Result.ViewName);
        }

        [Test]
        public void Index_TestWhereIdIsEqualOneReturnsAdmin()
        {
            //Act
            ViewResult Result = controllerAdmin.Index(1) as ViewResult;

            //Assert
            Assert.IsTrue((Result.ViewData["admin"] as AdminModel).admin_Id == 1);
        }

        //Arrange
        HomeController controllerHome = new HomeController();

        [Test]
        public void AboutUs_TestNameViewIsAboutUs()
        {
            ViewResult Result = controllerHome.AboutUs() as ViewResult;

            //Assert
            Assert.IsTrue(Result.ViewName == "AboutUs" || Result.ViewName == null);

        }

    }
}
