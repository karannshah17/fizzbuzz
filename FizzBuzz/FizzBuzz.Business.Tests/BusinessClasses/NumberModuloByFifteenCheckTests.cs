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
    class NumberModuloByFifteenCheckTests
    {
        private readonly DateTime DayWednesday = new DateTime(2019, 7, 10);
        private readonly DateTime DayFriday = new DateTime(2019, 7, 12);
        [Test]
        public void NumberModuloByFifteenConstructor_Return_Type_Test()
        {
            var mockRepo = new Mock<IDateTimeProvider>();
            INumberModuloCheck NumberModuloByFifteen = new NumberModuloByFifteenCheck((IDateTimeProvider)mockRepo.Object);
            Assert.IsTrue(null != NumberModuloByFifteen, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberModuloByFifteen.OutputString(5).GetType(), "Number modulo by fifteen class should return string type");
        }

        [Test]
        public void NumberModuloByFifteen_OutputString_WizzWuzz_Check_Wednesday()
        {

            var mockRepo = new Mock<IDateTimeProvider>();
            mockRepo.Setup(x => x.GetNow()).Returns(DayWednesday);
            string expected = "WizzWuzz";
            var numberModuloByFifteen = new NumberModuloByFifteenCheck((IDateTimeProvider)mockRepo.Object);
            string actual = numberModuloByFifteen.OutputString(15);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByFifteen_OutputString_FizzBuzz_Check_NonWednesday()
        {

            var mockRepo = new Mock<IDateTimeProvider>();
            mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "FizzBuzz";
            var numberModuloByFifteen = new NumberModuloByFifteenCheck((IDateTimeProvider)mockRepo.Object);
            string actual = numberModuloByFifteen.OutputString(15);
            Assert.AreEqual(actual, expected);

        }
    }
}
