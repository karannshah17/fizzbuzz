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
        INumberModuloCheck defaultModuloCheck;
        [SetUp]
        public void TestInit()
        {
            defaultModuloCheck = new DefaultModuloCheck();

        }
        
        [Test]
        public void DefaultModuloConstructor_Return_Type_Test()
        {
          
            string expected = "1";
            
            string actual = defaultModuloCheck.OutputStringBasedOnRule(1);
            Assert.AreEqual(actual, expected);
            //    Assert.IsTrue(null != NumberString, "Construction failed");
            //    Assert.IsTrue(typeof(string) == NumberString.OutputStringBasedOnRule(5).GetType(), "Number String class should return string type");
        }

    }
}
