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
        IExceptionalDayCheck _exceptionalDayCheck;

        public NumberModuloByFiveCheck(IExceptionalDayCheck exceptionalDayCheck)
        {
            _exceptionalDayCheck = exceptionalDayCheck;
        }
        public string OutputStringBasedOnRule(int number)
        {
            if (number % 5 == 0)
            {
                return _exceptionalDayCheck.IsExceptionalDayCheck() ? "Wuzz" : "Buzz";
            }
            return string.Empty;
        }
    }
}
