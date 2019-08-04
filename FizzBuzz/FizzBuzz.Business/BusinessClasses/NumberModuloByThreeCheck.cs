using FizzBuzz.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.BusinessClasses
{
    public class NumberModuloByThreeCheck : INumberModuloCheck
    {
        IDateTimeProvider _dateTimeProvider;

        public NumberModuloByThreeCheck(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }
        public string OutputString(int number)
        {
            if (number % 3 == 0)
            {
                return _dateTimeProvider.GetNow().DayOfWeek == DayOfWeek.Wednesday ? "Wizz" : "Fizz";

            }

            return string.Empty;
        }
    }
}
