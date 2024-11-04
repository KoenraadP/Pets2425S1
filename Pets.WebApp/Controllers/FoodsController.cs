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
            // alle Brands opzoeken in databank en in list steken
            List<Brand> brands = BrandsBll.Read();
            // list van brands klaarzetten als 'SelectList' om in een dropdown menu te plaatsen
            SelectList brandsList = new SelectList(brands, "BrandId", "Name");
            // selectlist in viewbag stoppen om dit te kunnen opvragen op de view
            ViewBag.AllBrands = brandsList;
            return View();
        }

        [HttpPost]
        // de selectedBrand is eigenlijk een Guid maar momenteel nog in string vorm
        public ActionResult Create(string name, string description, decimal price, 
            int amountInStock, bool inStock, double weight, string selectedBrand)
        {
            FoodsBll.Create(name, description, price, amountInStock, 
                inStock, weight, selectedBrand);

            return RedirectToAction("Index");
        }
    }
}