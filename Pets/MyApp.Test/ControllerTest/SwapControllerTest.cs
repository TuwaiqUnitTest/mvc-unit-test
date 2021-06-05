using NUnit.Framework;
using Pets.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Test.ControllerTest
{
    class SwapControllerTest
    {
        [Test]
        public void swapTest()
        {
            int number1 = 4;
            int number2 = 8;
            int expectedNo1 = 8;
            int expectedNo2 = 4;

            SwapController obj = new SwapController();
            obj.swap(ref number1,ref number2);

            Assert.AreEqual(expectedNo1, number1);
            Assert.AreEqual(expectedNo2, number2);
        }
    }
}
