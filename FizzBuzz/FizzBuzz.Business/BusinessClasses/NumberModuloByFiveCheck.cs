using FizzBuzz.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.BusinessClasses
{
    public class NumberModuloByFiveCheck : INumberModuloCheck
    {
        IDateTimeProvider _dateTimeProvider;

        public NumberModuloByFiveCheck(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }
        public string OutputString(int number)
        {
            throw new NotImplementedException();
        }
    }
}
