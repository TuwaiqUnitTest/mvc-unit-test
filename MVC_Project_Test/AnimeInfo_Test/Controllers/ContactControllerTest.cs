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
    [TestFixture]
    class ContactControllerTest
    {
        [Test]
        public void Index_ViewName_AreEqual()
        {
            ContactController controllerobj = new ContactController();
            ViewResult viewResultObj = controllerobj.Index() as ViewResult;
            Assert.AreEqual("Contact", viewResultObj.ViewName);
        }
        
    }
}
