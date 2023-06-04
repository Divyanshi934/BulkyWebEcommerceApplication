using BulkyWebEcommerceApplication.Data;
using BulkyWebEcommerceApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWebEcommerceApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}
