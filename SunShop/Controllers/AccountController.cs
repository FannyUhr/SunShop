using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SunShop.Models;

namespace SunShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AccountMenu()
        {
            return View();
        }

        public IActionResult AccountPage()
        {
            return View();
        }
    }
}