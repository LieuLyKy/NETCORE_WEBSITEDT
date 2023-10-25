using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WEBBANTBDTK.Models;

namespace WEBBANTBDTK.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbWEBTBDTKContext _context;
        public ProductController(dbWEBTBDTKContext context)
        {
            _context = context;
        }
        [Route("shop.html", Name = ("ShopProduct"))]
        public IActionResult Index(int? page)
        {
            try
            {              
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 8;
                var lsTinDangs = _context.Products
                    .AsNoTracking()
                    .OrderBy(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsTinDangs, pageNumber, pageSize);

                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [Route("danhmuc/{Alias}", Name = ("ListProduct"))]
        public IActionResult List(string Alias, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);

                var lsTinDangs = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == danhmuc.CatId)
                    .OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsTinDangs, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

        [Route("/{Alias}-{id}.html", Name = ("ProductDetails"))]
        public IActionResult Details(int id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                    .Take(4)
                    .OrderByDescending(x => x.DateCreated)
                    .ToList();
                ViewBag.SanPham = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

        public IActionResult ProductCategory(string alias, int id, string name, string sortOrder)
        {
            ViewBag.SortByName = String.IsNullOrEmpty(sortOrder) ? "ten_desc" : "";
            ViewBag.SortByPrice = (sortOrder == "dongia" ? "dongia_desc" : "dongia");

            IEnumerable<Product> items = _context.Products.OrderByDescending(x => x.ProductId);

            switch (sortOrder)
            {
                case "ten_desc":
                    items = _context.Products.OrderByDescending(x => x.Title);
                    break;
                case "dongia_desc":
                    items = _context.Products.OrderByDescending(x => x.Price);
                    break;
                case "dongia":
                    items = _context.Products.OrderBy(x => x.Price);
                    break;
                default: // mặc định sắp xếp theo tên sản phẩm
                    items = _context.Products.OrderBy(x => x.Title);
                    break;

            }

            //var items = data.Products.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.CatId == id).ToList();
            }
            var cate = _context.Categories.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.Cate = id;
            return View(items);


        }
    }
}
