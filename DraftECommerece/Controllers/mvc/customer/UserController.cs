using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DraftECommerece.Controllers.mvc.customer
{

    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

    } // end of User Controller

}
