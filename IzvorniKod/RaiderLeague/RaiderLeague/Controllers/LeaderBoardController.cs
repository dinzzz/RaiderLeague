using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RaiderLeague.Controllers
{
    public class LeaderBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoggedIn()
        {
            return View();
        }

        //ovdje bi mogao ici dio koda koji obraduje podatke u bazi i ovdje prikazuje leaderboard
    }
}