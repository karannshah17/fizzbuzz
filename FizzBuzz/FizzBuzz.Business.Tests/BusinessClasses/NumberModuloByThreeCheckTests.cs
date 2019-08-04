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
    class NumberModuloByThreeCheckTests
    {
        private readonly DateTime DayWednesday = new DateTime(2019, 7, 10);
        private readonly DateTime DayFriday = new DateTime(2019, 7, 12);

        [Test]
        public void NumberModuloByThreeConstructor_Return_Type_Test()
        {
            var mockRepo = new Mock<IDateTimeProvider>();

            INumberModuloCheck NumberModuloByThree = new NumberModuloByThreeCheck((IDateTimeProvider)mockRepo.Object);
            Assert.IsTrue(null != NumberModuloByThree, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberModuloByThree.OutputString(5).GetType(), "Number modulo by 3 should return string type");
        }

        [Test]
        public void NumberModuloByThree_OutputString_Wizz_Check_Wednesday()
        {

            var mockRepo = new Mock<IDateTimeProvider>();
            mockRepo.Setup(x => x.GetNow()).Returns(DayWednesday);
            string expected = "Wizz";
            var numberModuloByThree = new NumberModuloByThreeCheck((IDateTimeProvider)mockRepo.Object);
            string actual = numberModuloByThree.OutputString(3);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByThree_OutputString_Fizz_Check_NonWednesday()
        {

            var mockRepo = new Mock<IDateTimeProvider>();
            mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "Fizz";
            var numberModuloByThree = new NumberModuloByThreeCheck((IDateTimeProvider)mockRepo.Object);
            string actual = numberModuloByThree.OutputString(3);
            Assert.AreEqual(actual, expected);

        }
    }
}
