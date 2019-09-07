// <copyright file="FizzBuzzCustomHelper.cs" company="Fizz Buzz">
// Copyright (c) Fizz Buzz. All rights reserved.
// </copyright>

namespace FizzBuzz.Web.CustomHTMLHelper
{
    using System.Web.Mvc;

    public static class FizzBuzzCustomHelper
    {
        public static MvcHtmlString DisplayCustomFizzBuzz(this HtmlHelper helper, string stringBasedOnRule)
        {
            if (stringBasedOnRule == "FizzBuzz")
            {
                return MvcHtmlString.Create(string.Format("<span class='fizz'>Fizz</span><span class='buzz'>Buzz</span>"));
            }
            else
            {
                return MvcHtmlString.Create(string.Format("<span class=" + stringBasedOnRule.ToLower() + ">" + stringBasedOnRule + "</span>"));
            }
        }
    }
}