using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WEBBANTBDTK.Models;
using WEBBANTBDTK.ModelViews;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBBANTBDTK.Controllers
{
    public class SearchController : Controller
    {
        private readonly dbWEBTBDTKContext _context;

        public SearchController(dbWEBTBDTKContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string name, int? to, int? from)
        {
            var products = from b in _context.Products select b;
            if(!string.IsNullOrEmpty(name))
            {
                if(to != null && from !=null)
                {
                    products = products.Where(x => x.Title.Contains(name) && x.Price>=to && x.Price<=from);
                }
                else
                {
                    products = products.Where(x => x.Title.Contains(name));
                }
               
            }
            else
            {
                if (to != null && from != null)
                {
                    products = products.Where(x => x.Price >= to && x.Price <= from);
                }
            }    
            return View(products);
        }
    }
}
