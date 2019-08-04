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
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}