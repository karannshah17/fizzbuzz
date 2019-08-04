using FizzBuzz.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Web.Repository
{
    public class OutputStringService : IOutputStringService
    {
        private readonly INumberModuloCheck[] _NumberModuloCheckProviders;


        public OutputStringService(INumberModuloCheck[] NumberModuloCheckProviders)
        {
            this._NumberModuloCheckProviders = NumberModuloCheckProviders;

        }
        public List<string> getNumber(int number)
        {
            List<string> lststr = new List<string>();
            for (int i = 1; i < number; i++)
            {
                var strNumber = string.Empty;

                foreach (var numberModuloCheck in _NumberModuloCheckProviders)
                {

                    var strData = numberModuloCheck.OutputString(i);
                    if (strData != string.Empty)
                    {
                        strNumber = strData;
                        break;
                    }

                }
                lststr.Add(strNumber);
            }
            return lststr;
        }
    }
}