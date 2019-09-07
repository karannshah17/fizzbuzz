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
     
        INumberModuloCheck numberModuloByFifteenForTrue;
        INumberModuloCheck numberModuloByFifteenForFalse;
        [SetUp]
        public void TestInit()
        {
            // Runs before each test. (Optional)
            var mockRepoForTrue = new Mock<IExceptionalDayCheck>();
            var mockRepoForFalse = new Mock<IExceptionalDayCheck>();
            numberModuloByFifteenForTrue = new NumberModuloByFifteenCheck((IExceptionalDayCheck)mockRepoForTrue.Object);
            numberModuloByFifteenForFalse = new NumberModuloByFifteenCheck((IExceptionalDayCheck)mockRepoForFalse.Object);
            mockRepoForTrue.Setup(X => X.IsExceptionalDayCheck()).Returns(true);
            mockRepoForFalse.Setup(X => X.IsExceptionalDayCheck()).Returns(false);
        }
        //[Test]
        //public void NumberModuloByFifteenConstructor_Return_Type_Test()
        //{
            
        //    Assert.IsTrue(null != NumberModuloByFifteen, "Construction failed");
        //    Assert.IsTrue(typeof(string) == NumberModuloByFifteen.OutputStringBasedOnRule(5).GetType(), "Number modulo by fifteen class should return string type");
        //}

        [Test]
        public void NumberModuloByFifteen_OutputString_Returns_WizzWuzz_When_ExceptionalDay_Returns_True()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayWednesday);
            string expected = "WizzWuzz";
            //var numberModuloByFifteen = new NumberModuloByFifteenCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByFifteenForTrue.OutputStringBasedOnRule(15);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByFifteen_OutputString_Returns_FizzBuzz_When_ExceptionalDay_Returns_False()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "FizzBuzz";
            //var numberModuloByFifteen = new NumberModuloByFifteenCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByFifteenForFalse.OutputStringBasedOnRule(15);
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void NumberModuloByFifteen_OutputString_Returns_Empty_String_For_Number_Not_Multiple_Of_Five_On_Any_Day()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "";
            //var numberModuloByFifteen = new NumberModuloByFifteenCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByFifteenForFalse.OutputStringBasedOnRule(14);
            Assert.AreEqual(actual, expected);

        }
    }
}
