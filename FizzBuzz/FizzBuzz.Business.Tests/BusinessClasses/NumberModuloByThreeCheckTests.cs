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
        [Test]
        public void NumberModuloByThreeConstructor_Return_Type_Test()
        {
            var mockRepo = new Mock<IDateTimeProvider>();

            INumberModuloCheck NumberModuloByThree = new NumberModuloByThreeCheck((IDateTimeProvider)mockRepo.Object);
            Assert.IsTrue(null != NumberModuloByThree, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberModuloByThree.OutputString(5).GetType(), "Number modulo by 3 should return string type");
        }
    }
}
