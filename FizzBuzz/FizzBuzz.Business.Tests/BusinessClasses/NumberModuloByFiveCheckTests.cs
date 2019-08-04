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
        [Test]

        public void NumberModuloByFiveConstructor_Return_Type_Test()
        {
            var mockRepo = new Mock<IDateTimeProvider>();
            INumberModuloCheck NumberModuloByFive = new NumberModuloByFiveCheck((IDateTimeProvider)mockRepo.Object);
            Assert.IsTrue(null != NumberModuloByFive, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberModuloByFive.OutputString(5).GetType(), "Number modulo by Five should return string type");
        }
    }
}
