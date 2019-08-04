using FizzBuzz.Web.Models;
using FizzBuzz.Web.Repository;
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
            return null;
        }
        }
}