using FizzBuzz.Business.BusinessClasses;
using FizzBuzz.Business.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.Tests.BusinessClasses
{
    class DefaultModuloCheckTests
    {
        [Test]
        public void DefaultModuloConstructor_Return_Type_Test()
        {
            INumberModuloCheck NumberString = new DefaultModuloCheck();
            Assert.IsTrue(null != NumberString, "Construction failed");
            Assert.IsTrue(typeof(string) == NumberString.OutputString(5).GetType(), "Number String class should return string type");
        }

    }
}
