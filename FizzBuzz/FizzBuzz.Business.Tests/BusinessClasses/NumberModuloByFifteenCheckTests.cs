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
        [Test]
        public void NumberModuloByFifteenConstructor_Return_Type_Test()
        {
            var mockRepo = new Mock<IDateTimeProvider>();
            INumberModuloCheck NumberModuloByFifteen = new NumberModuloByFifteenCheck((IDateTimeProvider)mockRepo.Object);
            Assert.IsTrue(null != NumberModuloByFifteen, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberModuloByFifteen.OutputString(5).GetType(), "Number modulo by fifteen class should return string type");
        }
    }
}
