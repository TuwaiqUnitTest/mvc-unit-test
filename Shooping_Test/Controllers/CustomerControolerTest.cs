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
    public class CustomerControolerTest
    {
        [TestMethod]
      
            public void Index_View_Name_Index()
            {
            CustomerController Controller = new CustomerController();

                ViewResult Result = Controller.Index() as ViewResult;

                bool NameIsIndex = Result.ViewName == "Index" || Result.ViewName == null;

                Assert.IsTrue(NameIsIndex);
            }


       
        [TestMethod]

        public void Index__Customer_Type_DataArray_From_Model()
        {
            //Arrange
            CustomerController Controller = new CustomerController();
            //Act

            ViewResult Result = Controller.Index() as ViewResult;

            bool TypeOfproduct = Result.ViewData["customer"].GetType() == typeof(List<Customer>);
            //Assert

            Assert.IsTrue(TypeOfproduct, "No Type Of Customer List");
        }
      
        

    }
}
