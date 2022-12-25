using DraftECommerece.Data;
using DraftECommerece.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DraftECommerece.Controllers.mvc.admin
{


    public class ProductTypeController : Controller
    {
        private ApplicationDbContext _db;

        public ProductTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            //var productType = _db.tbl_Foundation_ProductTypes.ToList();
            return View(_db.tbl_Foundation_ProductTypes.ToList());
        }

        // Get Create action Method
        public IActionResult Create()
        {
            return View();
        }

        // POST Create action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(tbl_Foundation_ProductTypes tblproductType)
        {
            if (ModelState.IsValid)
            {
                await _db.tbl_Foundation_ProductTypes.AddAsync(tblproductType);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product Types has been save successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(tblproductType);
        }

        // Get Edit action Method
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.tbl_Foundation_ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        // POST Edit action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(tbl_Foundation_ProductTypes tblproductType)
        {
            if (ModelState.IsValid)
            {
                _db.Update(tblproductType);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(tblproductType);
        }

        // Get Details action Method
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.tbl_Foundation_ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        // POST Details action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(tbl_Foundation_ProductTypes tblproductType)
        {
            return RedirectToAction(nameof(Index));

        }

        // Get Delete action Method
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.tbl_Foundation_ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        // POST Delete action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id ,tbl_Foundation_ProductTypes tblproductType)
        {

            if (id == null)
            {
                return NotFound();
            }

            if (id != tblproductType.Id)
            {
                return NotFound();
            }

            var productType = _db.tbl_Foundation_ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Product Type has been delete successfully";
                return RedirectToAction(nameof(Index));

            }

            return View(tblproductType);

        }

        


    }// end of Product Type Controller
}
