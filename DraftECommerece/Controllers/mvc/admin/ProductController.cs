using DraftECommerece.Data;
using DraftECommerece.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DraftECommerece.Controllers.mvc.admin
{
    
    public class ProductController : Controller
    {

        private ApplicationDbContext _db;
        private IWebHostEnvironment _he;

        public ProductController(ApplicationDbContext db, IWebHostEnvironment he)
        {
            _db = db;
            _he = he;
        }

        public IActionResult Index()
        {
            return View(_db.tbl_Foundation_Products.Include(c=>c.ProductTypes).ToList());
        }

        // Post Index action method
        [HttpPost]
        public IActionResult Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = _db.tbl_Foundation_Products.Include(c=>c.ProductTypes)
                .Where(c=>c.PriceProduct >= lowAmount && c.PriceProduct <= largeAmount).ToList();
            if (lowAmount == null || largeAmount == null)
            {
                products = _db.tbl_Foundation_Products.Include(c => c.ProductTypes).ToList();
            }

            return View(products);
        }



        // Get Create method
        public IActionResult Create()
        {

            ViewData["productTypeId"] = new SelectList(_db.tbl_Foundation_ProductTypes.ToList(), "Id", "ProductType");

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        // Post Create method
        [HttpPost]
        public async Task<IActionResult> Create(tbl_Foundation_Products products)
        {

            if (ModelState.IsValid)
            {

                var searchProduct = _db.tbl_Foundation_Products.FirstOrDefault(c=>c.NameProduct == products.NameProduct);
                if (searchProduct != null)
                {
                    ViewBag.message = "This product is already exists";
                    ViewData["productTypeId"] = new SelectList(_db.tbl_Foundation_ProductTypes.ToList(), "Id", "ProductType");
                    return View();
                }

                if (products.UploadImageProduct != null)
                {
                    var name = Path.Combine(_he.WebRootPath+"/images/imgdb",Path.GetFileName(products.UploadImageProduct.FileName));
                    await products.UploadImageProduct.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.ImageProduct = "images/imgdb/"+products.UploadImageProduct.FileName;

                }

                if (products.UploadImageProduct == null)
                {
                    products.ImageProduct = "images/imgwebsite/notfoundimage.png";
                }

                _db.tbl_Foundation_Products.Add(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            return View(products);
        }

        // Get Edit method
        public IActionResult Edit(int? id)
        {

            ViewData["productTypeId"] = new SelectList(_db.tbl_Foundation_ProductTypes.ToList(), "Id", "ProductType");
            if (id == null)
            {
                return NotFound();
            }

            var product= _db.tbl_Foundation_Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // Post Edit Action method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(tbl_Foundation_Products products)
        {

            if (ModelState.IsValid)
            {

                if (products.UploadImageProduct != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/images/imgdb", Path.GetFileName(products.UploadImageProduct.FileName));
                    await products.UploadImageProduct.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.ImageProduct = "images/imgdb/" + products.UploadImageProduct.FileName;

                }

                if (products.UploadImageProduct == null)
                {
                    products.ImageProduct = "images/imgwebsite/notfoundimage.png";
                }

                _db.tbl_Foundation_Products.Update(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(products);
        }

        // Get Details Action method
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.tbl_Foundation_Products.Include(c=>c.ProductTypes).FirstOrDefault(c => c.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // Get Delete Action method
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.tbl_Foundation_Products.Include(c=>c.ProductTypes).Where(c=>c.Id == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var product = _db.tbl_Foundation_Products.FirstOrDefault(c=>c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            _db.Remove(product);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }// end of Product Controller

}
/*


[DisplayName("Choose Image")]
        public string ProjectImage { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }


public async Task<IActionResult> Create([Bind("Id,ProjectName,ProjectDescription,ImageFile")] Project project)
        {
            if (ModelState.IsValid)
            {
                // Save Image to wwwRoot/Img
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(project.ImageFile.FileName);
                string extension = Path.GetExtension(project.ImageFile.FileName);
                project.ProjectImage = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/img/", filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await project.ImageFile.CopyToAsync(fileStream);
                }

                // insert recored
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }








*/
