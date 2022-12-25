using DraftECommerece.Data;
using DraftECommerece.Models;
using DraftECommerece.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftECommerece.Controllers.mvc.customer
{
    public class OrderController : Controller
    {


        private ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }


        // Get Checkout action method

        public IActionResult Checkout()
        {
            return View();
        }

        // Post Checkout action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(tbl_Foundation_Order anOderder)
        {
            List<tbl_Foundation_Products> prodcuts = HttpContext.Session.Get<List<tbl_Foundation_Products>>("products");
            
            if (prodcuts != null)
            {
                foreach (var product in prodcuts)
                {
                    tbl_Foundation_OrderDetails orderDetails = new tbl_Foundation_OrderDetails();
                    orderDetails.ProdcutId = product.Id;
                    //anOderder.OrderDetails = new List<tbl_Foundation_OrderDetails>();
                    anOderder.OrderDetails.Add(orderDetails);
                }
            }

            anOderder.OrderNo = GetOrderNo();
            _db.tbl_Foundation_Order.Add(anOderder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<tbl_Foundation_Products>());

            return View();
        }


        public string GetOrderNo()
        {
            int rowCount = _db.tbl_Foundation_Order.ToList().Count()+1;

            return rowCount.ToString("000");

        }




    } // end of Order Controller 
}
