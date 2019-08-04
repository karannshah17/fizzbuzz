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
    class DateProviderTests
    {
        [Test]
        public void DateProviderTest()
        {
            IDateTimeProvider dateTimeProvider = new DateProvider();

            Assert.IsTrue(null != dateTimeProvider, "Construction failed");
            Assert.IsTrue(DateTime.Now.Date == dateTimeProvider.GetNow().Date, "Datetime should return todays date");
        }
    }
}
