using FizzBuzz.Business.Core;
using System;

namespace FizzBuzz.Business.BusinessClasses
{
    public class NumberModuloByThreeCheck : INumberModuloCheck
    {
        IExceptionalDayCheck _exceptionalDayCheck;

        public NumberModuloByThreeCheck(IExceptionalDayCheck exceptionalDayCheck)
        {
            _exceptionalDayCheck = exceptionalDayCheck;
        }
        public string OutputStringBasedOnRule(int number)
        {
            if (number % 3 == 0)
            {
                return _exceptionalDayCheck.IsExceptionalDayCheck() ? "Wizz" : "Fizz";
            }

            return string.Empty;
        }
    }
}
