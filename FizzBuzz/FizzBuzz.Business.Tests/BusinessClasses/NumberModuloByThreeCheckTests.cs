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
        INumberModuloCheck numberModuloByThreeForTrue;
        INumberModuloCheck numberModuloByThreeForFalse;
        [SetUp]
        public void TestInit()
        {
            // Runs before each test. (Optional)
            var mockRepoForTrue = new Mock<IExceptionalDayCheck>();
            var mockRepoForFalse = new Mock<IExceptionalDayCheck>();
            numberModuloByThreeForTrue = new NumberModuloByThreeCheck((IExceptionalDayCheck)mockRepoForTrue.Object);
            numberModuloByThreeForFalse = new NumberModuloByThreeCheck((IExceptionalDayCheck)mockRepoForFalse.Object);
            mockRepoForTrue.Setup(X => X.IsExceptionalDayCheck()).Returns(true);
            mockRepoForFalse.Setup(X => X.IsExceptionalDayCheck()).Returns(false);
        }

        //[Test]
        //public void NumberModuloByThreeConstructor_Return_Type_Test()
        //{
        //    var mockRepo = new Mock<IExceptionalDayCheck>();

        //    INumberModuloCheck NumberModuloByThree = new NumberModuloByThreeCheck((IExceptionalDayCheck)mockRepo.Object);
        //    Assert.IsTrue(null != NumberModuloByThree, "Construction failed");
        //    Assert.IsTrue(typeof(string) == NumberModuloByThree.OutputStringBasedOnRule(5).GetType(), "Number modulo by 3 should return string type");
        //}

        [Test]
        public void NumberModuloByThree_OutputString_Returns_Wizz_When_ExceptionalDay_Returns_True()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayWednesday);
            string expected = "Wizz";
           // var numberModuloByThree = new NumberModuloByThreeCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByThreeForTrue.OutputStringBasedOnRule(3);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void NumberModuloByThree_OutputString_Returns_Fizz_When_ExceptionalDay_Returns_True()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "Fizz";
            //var numberModuloByThree = new NumberModuloByThreeCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByThreeForFalse.OutputStringBasedOnRule(3);
            Assert.AreEqual(actual, expected);

        }


        [Test]
        public void NumberModuloByThree_OutputString_Returns_Empty_String_For_Number_Not_Multiple_Of_Three_On_Any_Day()
        {

            //var mockRepo = new Mock<IExceptionalDayCheck>();
            //mockRepo.Setup(x => x.GetNow()).Returns(DayFriday);
            string expected = "";
            //var numberModuloByFifteen = new NumberModuloByFifteenCheck((IExceptionalDayCheck)mockRepo.Object);
            string actual = numberModuloByThreeForFalse.OutputStringBasedOnRule(2);
            Assert.AreEqual(actual, expected);

        }
    }
}
