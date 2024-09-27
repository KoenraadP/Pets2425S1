using Pets.Bll;
using Pets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pets.WebApp.Controllers
{
    public class FoodsController : Controller
    {
        // GET: Foods
        public ActionResult Index()
        {
            return View(FoodsBll.Read());
        }

        public ActionResult Create()
        {
            List<Brand> brands = BrandsBll.Read();
            SelectList brandsList = new SelectList(brands, "BrandId", "Name");
            ViewBag.AllBrands = brandsList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string description, decimal price, 
            int amountInStock, bool inStock, double weight, string selectedBrand)
        {
            FoodsBll.Create(name, description, price, amountInStock, 
                inStock, weight, selectedBrand);

            return RedirectToAction("Index");
        }
    }
}