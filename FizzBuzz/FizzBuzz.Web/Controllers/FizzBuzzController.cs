// <copyright file="HomeController.cs" company="Fizz Buzz">
// Copyright (c) Fizz Buzz. All rights reserved.
// </copyright>

namespace FizzBuzz.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using FizzBuzz.Web.Models;
    using FizzBuzz.Web.Repository;
    using PagedList;

    public class FizzBuzzController : Controller
    {
        private readonly IMessageService outputStringService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzController"/> class.
        /// </summary>
        /// <param name="outputStringService"></param>
        public FizzBuzzController(IMessageService outputStringService)
        {
            this.outputStringService = outputStringService;
        }

        public ActionResult Index()
        {
            this.ViewBag.message = "Welcome to the Fizz Buzz Logic.Please enter your Number!";

            return this.View(new NumberViewModel());

        }

        [HttpPost]
        public ActionResult Index(NumberViewModel model, int? page)
        {
            int pageSize = 20;
            int pageNumber = page ?? 1;

            if (this.ModelState.IsValid)
            {
                model.RuleBasedOutputLists = this.GetRuleBasedOutputLists(model.UserNumber).ToPagedList(pageNumber, pageSize);

                return this.View("DisplayOutput", model);
            }

            return this.View(model);
        }

        [HttpGet]
        public ActionResult DisplayOutput(int value, int? page)
        {
            int pageSize = 20;
            int pageNumber = page ?? 1;

            var model = new NumberViewModel();
            model.UserNumber = value;

            model.RuleBasedOutputLists = this.GetRuleBasedOutputLists(value).ToPagedList(pageNumber, pageSize);

            return this.View(model);
        }

        private IList<string> GetRuleBasedOutputLists(int number)
        {
            return this.outputStringService.GetRuleBasedStringLists(number);
        }
    }
}