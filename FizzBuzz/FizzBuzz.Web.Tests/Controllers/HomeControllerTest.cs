using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Web;
using FizzBuzz.Web.Controllers;
using NUnit.Framework;
using FizzBuzz.Web.Repository;
using Moq;
using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private Moq.Mock<IOutputStringService> mockService;
        [OneTimeSetUp]
        public void Init()
        {
            mockService = new Mock<IOutputStringService>();
        }
        [Test]
        public void Index_Welcome_message_check()
        {

            HomeController controller = new HomeController(mockService.Object);
            ViewResult result = controller.Index() as ViewResult;
            NUnit.Framework.Assert.AreEqual("Welcome to the Fizz Buzz Logic.Please enter your Number!", result.ViewBag.Message);
            NUnit.Framework.Assert.IsNotNull(result);
        }
        [Test]
        public void Home_Controller_to_return_Numbers()
        {
            var model = new NumberViewModel();
            model.UserNumber = 3;
            List<string> lststring = new List<string> { "1", "2" };
            mockService.Setup(x => x.getNumber(model.UserNumber)).Returns(lststring);
            HomeController homeController = new HomeController(mockService.Object);
            var result = homeController.Index(model, null) as ViewResult;
            var actual = (NumberViewModel)result.Model;
        }
    }
}
