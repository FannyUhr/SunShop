using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ArticleNumber { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
