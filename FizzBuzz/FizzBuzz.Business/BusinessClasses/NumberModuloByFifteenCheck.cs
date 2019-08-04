using FizzBuzz.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.BusinessClasses
{
    public class NumberModuloByFifteenCheck : INumberModuloCheck
    {
        IDateTimeProvider _dateTimeProvider;

        public NumberModuloByFifteenCheck(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }
        public string OutputString(int number)
        {
            throw new NotImplementedException();
        }
    }
}
