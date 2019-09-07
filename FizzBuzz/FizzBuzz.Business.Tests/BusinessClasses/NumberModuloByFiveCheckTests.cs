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

        INumberModuloCheck numberModuloByFiveForTrue;
        INumberModuloCheck numberModuloByFiveForFalse;
        [SetUp]
        public void TestInit()
        {
            // Runs before each test. (Optional)
            var mockRepoForTrue = new Mock<IExceptionalDayCheck>();
            var mockRepoForFalse = new Mock<IExceptionalDayCheck>();
            numberModuloByFiveForTrue = new NumberModuloByFiveCheck((IExceptionalDayCheck)mockRepoForTrue.Object);
            numberModuloByFiveForFalse = new NumberModuloByFiveCheck((IExceptionalDayCheck)mockRepoForFalse.Object);
            mockRepoForTrue.Setup(X => X.IsExceptionalDayCheck()).Returns(true);
            mockRepoForFalse.Setup(X => X.IsExceptionalDayCheck()).Returns(false);
        }
       // [Test]

        //public void NumberModuloByFiveConstructor_Return_Type_Test()
        //{
        //    var mockRepo = new Mock<IExceptionalDayCheck>();
        //    INumberModuloCheck NumberModuloByFive = new NumberModuloByFiveCheck((IExceptionalDayCheck)mockRepo.Object);
        //    Assert.IsTrue(null != NumberModuloByFive, "Construction failed");
        //    Assert.IsTrue(typeof(string) == NumberModuloByFive.OutputStringBasedOnRule(5).GetType(), "Number modulo by Five should return string type");
        //}
        [Test]
        public void NumberModuloByFive_OutputString_Returns_Wuzz_When_ExceptionalDay_Returns_True()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayWednesday);
            string expected = "Wuzz";
            //var numberModuloByFive = new NumberModuloByFiveCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByFiveForTrue.OutputStringBasedOnRule(5);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByFive_OutputString_Returns_Buzz__When_ExceptionalDay_Returns_False()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "Buzz";
           // var numberModuloByFive = new NumberModuloByFiveCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByFiveForFalse.OutputStringBasedOnRule(5);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByFive_OutputString_Returns_Empty_String_For_Number_Not_Multiple_Of_Five_On_Any_Day()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "";
            // var numberModuloByFive = new NumberModuloByFiveCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByFiveForFalse.OutputStringBasedOnRule(6);
            Assert.AreEqual(actual, expected);

        }
    }
}
