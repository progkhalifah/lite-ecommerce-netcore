using DraftECommerece.Data;
using DraftECommerece.Models;
using DraftECommerece.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DraftECommerece.Controllers.mvc.customer
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.tbl_Foundation_Products.Include(c=>c.ProductTypes).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Get Product details action method

        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.tbl_Foundation_Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
               return NotFound();
            }


            return View(product);
        }


        // POST Product details action method
        [HttpPost]
        [ActionName("Details")]
        public async Task<IActionResult> ProdcutDetails(int? id)
        {

            List<tbl_Foundation_Products> products = new List<tbl_Foundation_Products>();

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.tbl_Foundation_Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
               return NotFound();
            }
            products = HttpContext.Session.Get<List<tbl_Foundation_Products>>("products");
            if (products == null)
            {
                products = new List<tbl_Foundation_Products>();
            }
            products.Add(product);
            HttpContext.Session.Set("products", products);

            return View(product);
        }


        // Get Remove action method
        [ActionName("Remove")]
        public IActionResult RemoveToCart(int? id)
        {

            List<tbl_Foundation_Products> products = HttpContext.Session.Get<List<tbl_Foundation_Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(c => c.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction(nameof(Index));

        }


        [HttpPost]

        public IActionResult Remove(int? id)
        {

            List<tbl_Foundation_Products> products = HttpContext.Session.Get<List<tbl_Foundation_Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(c => c.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // GET product Cart action method
        public IActionResult Cart()
        {
            List<tbl_Foundation_Products> products = HttpContext.Session.Get<List<tbl_Foundation_Products>>("products");
            if (products == null)
            {
                products = new List<tbl_Foundation_Products>();
            }
            return View(products);
        }

    }
}
