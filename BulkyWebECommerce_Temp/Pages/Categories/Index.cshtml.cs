using BulkyWebECommerce_Temp.Data;
using BulkyWebECommerce_Temp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebECommerce_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContaxt _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContaxt db) { 
        
            _db = db;
        } 
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
