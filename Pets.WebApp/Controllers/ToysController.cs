using Pets.Bll;
using Pets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pets.WebApp.Controllers
{
    public class ToysController : Controller
    {
        // GET: Toys
        public ActionResult Index()
        {
            return View(ToysBll.Read());
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
            int amountInStock, bool inStock, string selectedBrand)
        {
            ToysBll.Create(name, description, price, amountInStock,
                inStock, selectedBrand);

            return RedirectToAction("Index");
        }
    }
}