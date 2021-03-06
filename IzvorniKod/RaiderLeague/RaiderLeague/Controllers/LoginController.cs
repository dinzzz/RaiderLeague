﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaiderLeague.Models;



namespace RaiderLeague.Controllers
{
    public class LoginController : Controller
    {
        private readonly RaiderLeagueContext _context;
        public IActionResult Index()
        {
            return RedirectToAction("Index", "LoggedIn"); // ovo bi trebalo ic na neku stranicu gdje ce se upisivait dnevnik/pretrazivati...(LoggedIn Controller)
        }


        public IActionResult Create()
        {
            return View();
        
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.RegisteredUser user)
        {
            
                if (ValidateUser(user.Username, user.Password))
                {
                    
                    return RedirectToAction("Index", "LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                    return View();
                }
            
           
        }
        



        public LoginController(RaiderLeagueContext context)
        {
            _context = context;
        }

        public bool ValidateUser(string username, string password)
        {
            IQueryable<RegisteredUser> list = _context.RegisteredUser.Where(d => (d.Username.Equals(username) && d.Password.Equals(password)));
            if (list.Any()) return true;
            return false;

        }
    }
}