using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Shopping.Controllers;
using Shopping.Models;

namespace Shooping_Test
{
    [TestClass]
    public class ProdectControllerTest
    {
        [TestMethod]
      
            public void Index_View_Name_Index()
            {
            ProdectController Controller = new ProdectController();

                ViewResult Result = Controller.Index() as ViewResult;

                bool NameIsIndex = Result.ViewName == "Index" || Result.ViewName == null;

                Assert.IsTrue(NameIsIndex);
            }

        
        [TestMethod]

        public void Index_View_has_List_Of_product()
        {
            //Arrange
            ProdectController Controller = new ProdectController();
            //Act

            ViewResult Result = Controller.Index() as ViewResult;

            bool HasProdect = Result.ViewData.ContainsKey("Prodect");

            //Assert
            Assert.IsTrue(HasProdect, "No Prodect");
        }
        [TestMethod]

        public void Index__Product_Type_DataArray_From_Model()
        {
            //Arrange
            ProdectController Controller = new ProdectController();
            //Act

            ViewResult Result = Controller.Index() as ViewResult;

            bool TypeOfproduct = Result.ViewData["Prodect"].GetType() == typeof(List<Prodect>);
            //Assert

            Assert.IsTrue(TypeOfproduct, "No Type Of product List");
        }
      
        

    }
}
