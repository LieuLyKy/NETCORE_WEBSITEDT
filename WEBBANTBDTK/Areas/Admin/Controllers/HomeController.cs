﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBBANTBDTK.Areas.Admin.Controllers
{
    [Area("Admin")]
   

    //[Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index(string returnUrl = null)
        {
            return View();
        }
    }
}
