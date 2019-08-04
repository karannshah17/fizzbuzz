using FizzBuzz.Web.Models;
using FizzBuzz.Web.Repository;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOutputStringService _outputStringService;
        // private FizzBuzzHandler _fizzBuzzHandler = null;

        public HomeController(IOutputStringService outputStringService)
        {
            _outputStringService = outputStringService;


        }
        public ActionResult Index()
        {
            ViewBag.message = "Welcome to the Fizz Buzz Logic.Please enter your Number!";
            return View(new NumberViewModel());
        }
        [HttpPost]
        public ActionResult Index(NumberViewModel model, int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            if (ModelState.IsValid)
            {
                model.Numbers = GetNumber(model.UserNumber).ToPagedList(pageNumber, pageSize);

                return View("ShowNumber", model);
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult ShowNumber(int value, int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            var model = new NumberViewModel();
            model.UserNumber = value;

            model.Numbers = GetNumber(value).ToPagedList(pageNumber, pageSize);

            return View(model);


        }
        private List<string> GetNumber(int number)
        {


            return _outputStringService.getNumber(number);
        }
    }
}