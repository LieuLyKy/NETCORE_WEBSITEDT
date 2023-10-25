using System;
using System.Collections.Generic;
using WEBBANTBDTK.Models;

namespace WEBBANTBDTK.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
