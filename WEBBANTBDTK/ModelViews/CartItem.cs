using System;
using WEBBANTBDTK.Models;

namespace WEBBANTBDTK.ModelViews
{
    public class CartItem
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public double TotalMoney => amount * product.Price.Value;
      
    }
}
