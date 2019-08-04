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
            throw new NotImplementedException();
        }
    }
}