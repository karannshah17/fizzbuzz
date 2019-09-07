
using FizzBuzz.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business.BusinessClasses
{
    public class DefaultModuloCheck : INumberModuloCheck
    {
        public string OutputStringBasedOnRule(int number)
        {
            return number.ToString();
        }
    }
}
