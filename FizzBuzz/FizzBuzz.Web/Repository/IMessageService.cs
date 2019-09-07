// <copyright file="IMessageService.cs" company="Fizz Buzz">
// Copyright (c) Fizz Buzz. All rights reserved.
// </copyright>

namespace FizzBuzz.Web.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMessageService
    {
        IList<string> GetRuleBasedStringLists(int number);
    }
}
