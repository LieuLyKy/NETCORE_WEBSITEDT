using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using WEBBANTBDTK.ExtsMR;
using WEBBANTBDTK.Helpper;
using WEBBANTBDTK.Models;
using WEBBANTBDTK.Models.Payments;
using WEBBANTBDTK.ModelViews;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly dbWEBTBDTKContext _context;
        public INotyfService _notyfService { get; }
        public CheckoutController(dbWEBTBDTKContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        [Route("checkout.html",Name ="Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            //Lay gio hang ra de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;
            }
         
            ViewBag.GioHang = cart;
            return View(model);
        }

        [HttpPost]
        [Route("checkout.html", Name ="Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            //Lay ra gio hang de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

              
             
                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
               
                    //Khoi tao don hang
                    Order donhang = new Order();
                    donhang.CustomerId = model.CustomerId;
                    donhang.Address = model.Address;
                 

                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;//Don hang moi
                    donhang.Deleted = false;
                    donhang.Paid = false;
                    donhang.Note = Utilities.StripHTML(model.Note);
                    donhang.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Add(donhang);
                    _context.SaveChanges();
                    //tao danh sach don hang

                    foreach (var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = donhang.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Amount = item.amount;
                        orderDetail.TotalMoney = donhang.TotalMoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);
                    }
                    _context.SaveChanges();
                    //clear gio hang
                    HttpContext.Session.Remove("GioHang");
                    //Xuat thong bao
                    _notyfService.Success("Đơn hàng đặt thành công");
                    //cap nhat thong tin khach hang
                    return RedirectToAction("Success");


                
            }
            catch 
            {
              
                ViewBag.GioHang = cart;
                return View(model);
            }
          
            ViewBag.GioHang = cart;
            return View(model);
        }
        [Route("dat-hang-thanh-cong.html",Name = "Success")]
        public IActionResult Success()
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CustomerId");
                if (string.IsNullOrEmpty(taikhoanID))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/dat-hang-thanh-cong.html" });
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                var donhang = _context.Orders
                    .Where(x => x.CustomerId == Convert.ToInt32(taikhoanID))
                    .OrderByDescending(x => x.OrderDate)
                    .FirstOrDefault();
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.DonHangID = donhang.OrderId;
                successVM.Phone = khachhang.Phone;
                successVM.Address = khachhang.Address;

                 if (donhang == null) return NotFound();

                //var chitietdonhang = _context.OrderDetails
                //    .Include(x => x.Product)
                //    .AsNoTracking()
                //    .Where(x => x.OrderId == id)
                //    .OrderBy(x => x.OrderDetailId)
                //    .ToList();
                //XemDonHang donHang = new XemDonHang();
                //donHang.DonHang = donhang;
                //donHang.ChiTietDonHang = chitietdonhang;
         
                return View(successVM);
            }
            catch 
            {
                return View();
            }
        }

        //public string UrlPayment(int TypePaymentVN, string orderCode)
        //{
        //    var urlPayment = "";
        //    var order = _context.Orders.FirstOrDefault(x => x.OrderId.ToString() == orderCode);
        //    //Get Config Info
        //    string vnp_Returnurl = ConfigurationManager.AppSettings["vnp_Returnurl"]; //URL nhan ket qua tra ve 
        //    string vnp_Url = ConfigurationManager.AppSettings["vnp_Url"]; //URL thanh toan cua VNPAY 
        //    string vnp_TmnCode = ConfigurationManager.AppSettings["vnp_TmnCode"]; //Ma định danh merchant kết nối (Terminal Id)
        //    string vnp_HashSecret = ConfigurationManager.AppSettings["vnp_HashSecret"]; //Secret Key

        //    //Build URL for VNPAY
        //    VnPayLibrary vnpay = new VnPayLibrary();
        //    var Price = (long)order.TotalMoney;
        //    vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
        //    vnpay.AddRequestData("vnp_Command", "pay");
        //    vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
        //    vnpay.AddRequestData("vnp_Amount", Price.ToString()); //Số tiền thanh toán. Số tiền không mang các ký tự phân tách thập phân, phần nghìn, ký tự tiền tệ. Để gửi số tiền thanh toán là 100,000 VND (một trăm nghìn VNĐ) thì merchant cần nhân thêm 100 lần (khử phần thập phân), sau đó gửi sang VNPAY là: 10000000
        //    if (TypePaymentVN == 1)
        //    {
        //        vnpay.AddRequestData("vnp_BankCode", "VNPAYQR");
        //    }
        //    else if (TypePaymentVN == 2)
        //    {
        //        vnpay.AddRequestData("vnp_BankCode", "VNBANK");
        //    }
        //    else if (TypePaymentVN == 3)
        //    {
        //        vnpay.AddRequestData("vnp_BankCode", "INTCARD");
        //    }
        //    //vnpay.AddRequestData("vnp_CreateDate", order.PaymentDate.ToString("yyyyMMddHHmmss"));
        //    vnpay.AddRequestData("vnp_CurrCode", "VND");
        //    vnpay.AddRequestData("vnp_IpAddr", Utils.GetIpAddress());
        //    vnpay.AddRequestData("vnp_Locale", "vn");
        //    vnpay.AddRequestData("vnp_OrderInfo", "Thanh toán đơn hàng :" + order.OrderId.ToString());
        //    vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other

        //    vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
        //    vnpay.AddRequestData("vnp_TxnRef", order.OrderId.ToString()); // Mã tham chiếu của giao dịch tại hệ thống của merchant. Mã này là duy nhất dùng để phân biệt các đơn hàng gửi sang VNPAY. Không được trùng lặp trong ngày

        //    //Add Params of 2.1.0 Version
        //    //Billing

        //    urlPayment = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
        //    //log.InfoFormat("VNPAY URL: {0}", paymentUrl);
        //    return urlPayment;
        //}

    }
}
