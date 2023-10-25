using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using WEBBANTBDTK.Models;
using WEBBANTBDTK.ModelViews;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WEBBANTBDTK.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SalesStatisticsController : Controller
    {
        private readonly dbWEBTBDTKContext _dbContext;

        public SalesStatisticsController(dbWEBTBDTKContext dbContext)
        {
            _dbContext = dbContext;
        }

     
        [HttpGet]
        public IActionResult Index(string returnUrl = null)
        {

            var productQuantities = _dbContext.OrderDetails
            .GroupBy(s => s.Product.ProductName)
            .Select(group => new ProductQuantityViewModel
            {
                ProductType = group.Key,
                Quantity = (int)group.Sum(s => s.Amount)
            })
            .ToList();

            decimal totalRevenue = (decimal)_dbContext.OrderDetails.Sum(s => s.Amount * s.Price);

            ViewData["TotalRevenue"] = totalRevenue;

            int totalQuantity = (int)_dbContext.OrderDetails.Sum(s => s.Amount);

            ViewData["TotalQuantity"] = totalQuantity;

            return View(productQuantities);
        }


       

        // [HttpGet]
        //[HttpGet]
        //public IActionResult GetTotalRevenue(string fromDate, string toDate)
        //{
        //    var query = from o in _dbContext.Orders
        //                join od in _dbContext.OrderDetails
        //                on o.OrderId equals od.OrderId
        //                join p in _dbContext.Products
        //                on od.ProductId equals p.ProductId
        //                select new
        //                {
        //                    CreatedDate = o.PaymentDate,
        //                    Quantity = od.Amount,
        //                    Price = od.Price,
        //                    //OriginalPrice = p.OriginalPrice
        //                };
        //    if (!string.IsNullOrEmpty(fromDate))
        //    {
        //        DateTime startDate = DateTime.ParseExact(fromDate, "dd/MM/yyyy", null);
        //        query = query.Where(x => x.CreatedDate >= startDate);
        //    }
        //    if (!string.IsNullOrEmpty(toDate))
        //    {
        //        DateTime endDate = DateTime.ParseExact(toDate, "dd/MM/yyyy", null);
        //        query = query.Where(x => x.CreatedDate < endDate);
        //    }

        //    var result = query.GroupBy(x => EF.Functions.Date(x.CreatedDate))
        //          .Selectt(x => new
        //    {
        //        Date = x.Key.Value,
        //              // tổng giá nhập
        //              Count = x.Count(),
        //        TotalBuy = x.Sum(y => y.Quantity * y.OriginalPrice),
        //        // tổng giá bán được số lượng bán đc * đơn giá
        //        TotalSell = x.Sum(y => y.Quantity * y.Price),
        //    }).Select(x => new
        //    {
        //        Date = x.Date,
        //        // gán tên
        //        DoanhThu = x.TotalSell,
        //        // trừ ra
        //        LoiNhuan = x.TotalSell - x.TotalBuy
        //    });
        //    return Json(new { Data = result }, JsonRequestBehavior.AllowGet);
        //}
    }
}
