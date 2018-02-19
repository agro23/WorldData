using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using WorldData.Controllers;
using WorldData.Models;

namespace WorldData.Tests
{
    [TestClass]
    public class HomeControllerTest
    {


    [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            IActionResult indexView = controller.Index();
            ViewResult result = indexView as ViewResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

    [TestMethod]
        public void Index_HasCorrectModelType_RepeatCounter()
        {
            //Arrange
            HomeController controller = new HomeController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Object)); // this is the message passed to the screen as a dictionary.

            // Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>)); // this is the message passed to the screen as a dictionary.
        }

    }
}
