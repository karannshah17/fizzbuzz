using FizzBuzz.Business.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.BusinessClasses
{
    public class ExceptionalDayCheck : IExceptionalDayCheck
    {
        string ExceptionalDay = ConfigurationManager.AppSettings["ExceptionalDay"];
        public bool IsExceptionalDayCheck()
        {
            return DateTime.Now.DayOfWeek.ToString() == ExceptionalDay;
        }
    }
}
