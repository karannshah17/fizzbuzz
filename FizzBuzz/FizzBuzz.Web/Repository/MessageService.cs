// <copyright file="MessageService.cs" company="Fizz Buzz">
// Copyright (c) Fizz Buzz. All rights reserved.
// </copyright>

namespace FizzBuzz.Web.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using FizzBuzz.Business.Core;
    //SAP Test Change
    public class MessageService : IMessageService
    {
        private readonly INumberModuloCheck[] numberModuloCheckProviders;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageService"/> class.
        /// </summary>
        /// <param name="numberModuloCheckProviders"></param>
        public MessageService(INumberModuloCheck[] numberModuloCheckProviders)
        {
            this.numberModuloCheckProviders = numberModuloCheckProviders;
        }

        /// <inheritdoc/>
        public IList<string> GetRuleBasedStringLists(int number)
        {
            List<string> lststr = new List<string>();
            for (int i = 1; i < number; i++)
            {
                var strNumber = string.Empty;

                foreach (var numberModuloCheck in this.numberModuloCheckProviders)
                {
                    var strData = numberModuloCheck.OutputStringBasedOnRule(i);
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