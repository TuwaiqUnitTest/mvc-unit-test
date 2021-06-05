using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Blog_Website.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1.Controllers
{
    class ArticlesControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Details_validId_DeatilsView()
        {
            ArticlesController Articles = new ArticlesController();
            ViewResult viewObj = (ViewResult)Articles.Details(2);
            Assert.AreEqual("Details", viewObj.ViewName);
        }

        [Test]
        public void Details_NonvalidId_NotFound()
        {
            ArticlesController Articles = new ArticlesController();
            ContentResult ContentObj = (ContentResult)Articles.Details(-5);
            Assert.AreEqual("Not found", ContentObj.Content);
        }


        [Test]
        public void Index_Id_IndexView()
        {
            ArticlesController Articles = new ArticlesController();
            ViewResult viewObj = (ViewResult)Articles.Index(2);
            Assert.AreEqual("Index", viewObj.ViewName);
        }

        [Test]
        public void Index_Id_CheackSameId()
        {
            ArticlesController Articles = new ArticlesController();
            ViewResult viewObj = (ViewResult)Articles.Index(2);
            Assert.AreEqual(2, viewObj.ViewData["id"]);
        }

        [Test]
        public void Index_NoId_CheackIfGiveMeNegativeNumber()
        {
            ArticlesController Articles = new ArticlesController();
            ViewResult viewObj = (ViewResult)Articles.Index();
            Assert.AreEqual(-1, viewObj.ViewData["id"]);
        }

        [Test]
        public void Index_CheakSameList()
        {
            ArticlesController Articles = new ArticlesController();
            ViewResult viewObj = (ViewResult)Articles.Index();
            Assert.AreEqual(Articles.Articles, viewObj.ViewData["Articles"]);

        }
    }
}
