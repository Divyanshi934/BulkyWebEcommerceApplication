using Microsoft.AspNetCore.Mvc;

namespace BulkyWebEcommerceApplication.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
