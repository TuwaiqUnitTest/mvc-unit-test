using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class HomeControllerTest
    {
        [TestMethod]
      
            public void Index_View_Name_Index()
            {
                HomeController Controller = new HomeController ();

                ViewResult Result = Controller.Index() as ViewResult;

                bool NameIsIndex = Result.ViewName == "Index" || Result.ViewName == null;

                Assert.IsTrue(NameIsIndex);
            }

      

    }
}
