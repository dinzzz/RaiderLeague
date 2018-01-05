using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RaiderLeague.Controllers
{
    public class UploadBattleLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Uploaded()
        {
            return View();
        }

       
    }
}