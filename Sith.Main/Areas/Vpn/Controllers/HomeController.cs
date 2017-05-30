// Copyright 2017 Vasylyk Andriy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sith.Main.Controllers
{
    [Area("Vpn")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}