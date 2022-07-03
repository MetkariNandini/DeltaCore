using DeltaCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeltaCore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<ProductsService> productlist = new List<ProductsService>();
            ProductsService products = new ProductsService();
            productlist.Add(new ProductsService
            {
                ProductID = 1001,
                Name = "Tools Gears",
                Description = "Gear tools production specification"
            });
            productlist.Add(new ProductsService
            {
                ProductID = 2001,
                Name = "Panels",
                Description = "Switch Gear Panels"
            });
            productlist.Add(new ProductsService
            {
                ProductID = 2008,
                Name = "DocTonar",
                Description = "Document Solar Objects"
            });
            return View(productlist);
        }
    }
}