﻿using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class HomeController : Controller
    {   
        //Index method and current home :)
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}