using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SunShop.Models;

namespace SunShop.Controllers
{
    public class ProductController : Controller
    {
        readonly List<Product> products = new List<Product>()
        {
            new Product {Id=1, ProductName="Ray-Ban", ArticleNumber="RB3447", Price=199.99, Description="A pair of sunglasses", Photo="../images/product/sunglasses1.jpg"}, //RB3447
            new Product {Id=2, ProductName="Ray-Ban", ArticleNumber="RB4246", Price=159.99, Description="A pair of sunglasses", Photo="../images/product/sunglasses2.jpg"}, //RB4246
            new Product {Id=3, ProductName="Ray-Ban", ArticleNumber="RB3016", Price=129.99, Description="A pair of sunglasses", Photo="../images/product/sunglasses3.jpg"}, //RB3016
            new Product {Id=4, ProductName="Ray-Ban", ArticleNumber="RB3574N", Price=149.99, Description="A pair of sunglasses", Photo="../images/product/sunglasses4.jpg"}, //RB3574N
            new Product {Id=5, ProductName="Ray-Ban", ArticleNumber="RB3648", Price=189.99, Description="A pair of sunglasses", Photo="../images/product/sunglasses5.jpg"}, //RB3648
            new Product {Id=6, ProductName="Ray-Ban", ArticleNumber="RB3547N", Price=159.99, Description="A pair of sunglasses", Photo="../images/product/sunglasses6.jpg"} //RB3547N
        };

        public PartialViewResult ProtoType()
        {
            return PartialView();
        }

        public IActionResult Store()
        {
            return View(products);
        }
    }
}