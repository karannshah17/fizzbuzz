using FizzBuzz.Business.Core;
using FizzBuzz.Web.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Web.Tests.Repositroy
{
    class OutputStringServiceTest
    {
        private INumberModuloCheck[] _NumberModuloCheckProviders;

        [OneTimeSetUp]
        public void Init()
        {
            var mockNumberByFifteenCheck = new Mock<INumberModuloCheck>();
            var mockNumberByFiveCheck = new Mock<INumberModuloCheck>();
            var mockNumberByThreeCheck = new Mock<INumberModuloCheck>();
            var mockDefaultModuloCheck = new Mock<INumberModuloCheck>();

            _NumberModuloCheckProviders = new INumberModuloCheck[] { mockNumberByFifteenCheck.Object,  mockNumberByFiveCheck.Object,
          mockNumberByThreeCheck.Object,mockDefaultModuloCheck.Object};

        }
        [Test]
        [TestCase(2, 1)]
        [TestCase(4, 3)]
        [TestCase(6, 5)]
        public void Check_Output_String_Service_Count(int input, int expectedCount)
        {
            IMessageService outputStringService = new MessageService(_NumberModuloCheckProviders);
            int ActualCount = outputStringService.GetRuleBasedStringLists(input).Count;
            Assert.AreEqual(expectedCount, ActualCount);
        }
    }
}
