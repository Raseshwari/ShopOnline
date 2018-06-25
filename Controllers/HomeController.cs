using Microsoft.AspNetCore.Mvc;
using ShopOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Controllers
{
    public class HomeController : Controller
    {
        private IWelcome _welcome;

        public HomeController(IWelcome welcome)
        {
            _welcome = welcome;
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
