using FizzBuzz.Business.BusinessClasses;
using FizzBuzz.Business.Core;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.Tests.BusinessClasses
{
    class NumberModuloByFiveCheckTests
    {
        private readonly DateTime DayWednesday = new DateTime(2019, 7, 10);
        private readonly DateTime DayFriday = new DateTime(2019, 7, 12);
        [Test]

        public void NumberModuloByFiveConstructor_Return_Type_Test()
        {
            var mockRepo = new Mock<IDateTimeProvider>();
            INumberModuloCheck NumberModuloByFive = new NumberModuloByFiveCheck((IDateTimeProvider)mockRepo.Object);
            Assert.IsTrue(null != NumberModuloByFive, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberModuloByFive.OutputString(5).GetType(), "Number modulo by Five should return string type");
        }
        [Test]
        public void NumberModuloByFive_OutputString_Wuzz_Check_Wednesday()
        {

            var mockRepo = new Mock<IDateTimeProvider>();
            mockRepo.Setup(x => x.GetNow()).Returns(DayWednesday);
            string expected = "Wuzz";
            var numberModuloByFive = new NumberModuloByFiveCheck((IDateTimeProvider)mockRepo.Object);
            string actual = numberModuloByFive.OutputString(5);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByFive_OutputString_Buzz_Check_NonWednesday()
        {

            var mockRepo = new Mock<IDateTimeProvider>();
            mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "Buzz";
            var numberModuloByFive = new NumberModuloByFiveCheck((IDateTimeProvider)mockRepo.Object);
            string actual = numberModuloByFive.OutputString(5);
            Assert.AreEqual(actual, expected);

        }
    }
}
