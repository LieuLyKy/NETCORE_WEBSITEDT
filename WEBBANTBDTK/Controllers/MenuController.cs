using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WEBBANTBDTK.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBBANTBDTK.ViewComponents
{
    public class MenuController : Controller
    {
     
      
        public IActionResult MnTraiProduct()
        {
         
            return ViewComponent("MnTraiProduct");
        }

       
    }
}
