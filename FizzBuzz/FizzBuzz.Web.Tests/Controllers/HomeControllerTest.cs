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
    }
}
