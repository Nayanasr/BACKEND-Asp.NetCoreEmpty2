using Asp.NetCoreEmpty2.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty2.Controllers
{
    public class HomeController : Controller
    {
        public ICart _cart;

        public HomeController(ICart cart) {
            _cart = cart;
        }

        public ViewResult Details() {
           Cart model = _cart.GetCart(1);
            ViewBag.Cart = model;
            ViewBag.Title = "Details of Cart";
            return View(); 
        }

        public IActionResult Index() {
            //return View("Details");
            //return View("../Test/Testing");
            return View("MyViews/Test.cshtml");
        }
        public IActionResult Cart() {
            return View();
        }


    }
}