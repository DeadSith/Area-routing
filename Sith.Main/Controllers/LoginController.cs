// Copyright 2017 Vasylyk Andriy
using System;
using Sith.Main.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sith.Main.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            throw new NotImplementedException();
        }

        public IActionResult Logout()
        {
            throw new NotImplementedException();
        }
    }
}