using AnimeInfo.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeInfo_Test.Controllers
{
    class AboutwebsiteControllerTest
    {

        [Test]
        public void Index_ViewName_AreEqual()
        {
            AboutwebsiteController controllerobj = new AboutwebsiteController();
            ViewResult viewResultObj = controllerobj.Index() as ViewResult;
            Assert.AreEqual("Aboutwebsite", viewResultObj.ViewName);
        }

    }
}
