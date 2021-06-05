using Event_Hall.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Event_HallTest.Controllers
{
    [TestFixture]
    class EventsControllerTest
    {
        [Test]
        public void Index_AdminView_AreEqual()
        {
            //Arrange
            EventsController ControllerObj = new EventsController();

            //Act
            ViewResult viewResultObj = ControllerObj.Index("Admin") as ViewResult;

            //Assert
            Assert.AreEqual("Admin", viewResultObj.ViewName);

        }

        [Test]
        public void Index_PresentorView_AreEqual()
        {
            //Arrange
            EventsController ControllerObj = new EventsController();

            //Act
            ViewResult viewResultObj = ControllerObj.Index("Presentor") as ViewResult;

            //Assert
            Assert.AreEqual("Presentor", viewResultObj.ViewName);

        }
        [Test]
        public void Index_IndexView_AreEqual()
        {
            //Arrange
            EventsController ControllerObj = new EventsController();

            //Act
            ViewResult viewResultObj = ControllerObj.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", viewResultObj.ViewName);

        }

    }
}
