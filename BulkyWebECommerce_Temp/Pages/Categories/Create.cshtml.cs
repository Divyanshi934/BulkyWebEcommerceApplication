using BulkyWebECommerce_Temp.Data;
using BulkyWebECommerce_Temp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebECommerce_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContaxt _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContaxt db)
        {

            _db = db;
        }
            public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
