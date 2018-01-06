using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaiderLeague.Models;

namespace RaiderLeague.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Login for registered users.";

            return RedirectToAction("Login", "Login");
        }
        public IActionResult Leaderboard()
        {
            return View();
        }

        public IActionResult Register()
        {
            //ViewData["Message"] = "Registration for unregistered users";
            return RedirectToAction("Create", "Register");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
