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
    public class FizzBuzzControllerTest
    {
        private Moq.Mock<IMessageService> mockService;
        [OneTimeSetUp]
        public void Init()
        {
            mockService = new Mock<IMessageService>();
        }
        [Test]
        public void Index_Welcome_message_check()
        {

            FizzBuzzController controller = new FizzBuzzController(mockService.Object);
            ViewResult result = controller.Index() as ViewResult;
            NUnit.Framework.Assert.AreEqual("Welcome to the Fizz Buzz Logic.Please enter your Number!", result.ViewBag.Message);
            NUnit.Framework.Assert.IsNotNull(result);
        }
        [Test]
        public void FizzBuzz_Controller_to_return_String()
        {
            var model = new NumberViewModel();
            model.UserNumber = 3;
            IList<string> lststring = new List<string> { "1", "2" };
            mockService.Setup(x => x.GetRuleBasedStringLists(model.UserNumber)).Returns(lststring);
            FizzBuzzController fizzBuzzController = new FizzBuzzController(mockService.Object);
            var result = fizzBuzzController.Index(model, null) as ViewResult;
            var actual = (NumberViewModel)result.Model;
        }
    }
}
