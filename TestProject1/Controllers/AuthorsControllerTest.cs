using Blog_Website.Controllers;
using Blog_Website.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TestProject1.Controllers
{

    class AuthorsControllerTest
    {

        [Test]
        public void Authors_IndexView()
        {
            AuthorsController Authors = new AuthorsController();
            ViewResult viewObj = (ViewResult)Authors.Index();
            Assert.AreEqual("Index", viewObj.ViewName);
            
        }

        [Test]
        public void Authors_CheakSameList()
        {
            AuthorsController Authors = new AuthorsController();
            ViewResult viewObj = (ViewResult)Authors.Index();
            Assert.AreEqual(Authors.authors, viewObj.ViewData["authors"]);

        }
    }
}
