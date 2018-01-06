
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaiderLeague.Models;

namespace RaiderLeague.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RaiderLeagueContext _context;

        public IActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }

        public RegisterController(RaiderLeagueContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind("ID,Username,Email,Password,Klasa")] RegisteredUser registeredUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registeredUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registeredUser);
        }
        public JsonResult IsUserExists(string UserName)
        {
            //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
            return Json(!_context.RegisteredUser.Any(x => x.Username == UserName));
        }
    }
}