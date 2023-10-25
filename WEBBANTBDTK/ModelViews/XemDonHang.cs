using System;
using System.Collections.Generic;
using WEBBANTBDTK.Models;

namespace WEBBANTBDTK.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
