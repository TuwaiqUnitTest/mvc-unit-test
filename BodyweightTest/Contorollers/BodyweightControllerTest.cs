using Bodyweight.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BodyweightTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Retuen_Home_Index()
        {
          
         
                //Arrange
                BodyweightController ControllerObj = new BodyweightController();

                //Act
                ViewResult viewResultObj = ControllerObj.Index() as ViewResult;

                //Assert
                Assert.AreEqual("Home", viewResultObj.ViewName);

           
        }

        [TestMethod]
        public void Get_perfect_body_weight_for_male_height_180()
        {

            //Arrange
            BodyweightController ControllerObj = new BodyweightController();

            //Act
          var result =  ControllerObj.perfect_Body_Wieght(180, "male");

          double expecte = 72.5;

            //Assert

            Assert.AreEqual(expecte, result);

        }
        [TestMethod]
        public void Get_perfect_body_weight_for_femaile_height_158()
        {

            //Arrange
            BodyweightController ControllerObj = new BodyweightController();

            //Act
            var result = ControllerObj.perfect_Body_Wieght(158, "femaile");

            double expecte = 54;

            //Assert

            Assert.AreEqual(expecte, result);

        }
        [TestMethod]
        public void Cass_no_wieght_to_test()
        {

            //Arrange
            BodyweightController ControllerObj = new BodyweightController();

            //Act
            var result = ControllerObj.perfect_Body_Wieght(0, "");

            double expecte = 0;

            //Assert

            Assert.AreEqual(expecte, result);

        }
    }
}
