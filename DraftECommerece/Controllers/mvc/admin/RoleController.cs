using DraftECommerece.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace DraftECommerece.Controllers.mvc.admin
{
    public class RoleController : Controller
    {

        RoleManager<IdentityRole> _roleManager;
        ApplicationDbContext _db;

        public RoleController(RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            ViewBag.Roles = roles;
            return View();

        }


        // Get Create Role Method
        public IActionResult Create()
        {
            return View();
        }

        // Post Create Role Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string name)
        {
            IdentityRole role = new IdentityRole();
            role.Name = name;
            var isExist = await _roleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                TempData["RoleExist"] = "Role is Exist";
            }
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                TempData["save"] = "Role has been saved successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        // Get Edit Role Method
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            ViewBag.id = role.Id;
            ViewBag.name = role.Name;

            return View();
        }

        // Post Edit Role Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string name, string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            role.Name = name;
            var isExist = await _roleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                TempData["RoleExist"] = "Role is Exist";
                return View();
            }
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                TempData["updateRole"] = "Role has been updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        
        
        
        
        // Get Delete Role Method
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            ViewBag.id = role.Id;
            ViewBag.name = role.Name;

            return View();
        }

        // Post Create Role Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName ("Delete")]
        public async Task<IActionResult> DeleteConfirm(string name, string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                TempData["deleteRole"] = "Role has been deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        public async Task<IActionResult> Assign()
        {
            ViewBag["UserId"] = new SelectList(_db.tbl_Foundation_Users.ToList(),"Id","UserName");
            ViewBag["RoleId"] = new SelectList(_roleManager.Roles.ToList(),"Id","Name");
            if (ViewBag["UserId"] == null)
            {
                return NotFound();
            }
            return View();
        }



    }// end of Role Controller 
}
