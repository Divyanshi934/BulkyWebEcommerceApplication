using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 51-100")]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 10000)]
        public double Price100 { get; set; }

        //Adding foreign key.
        //Tried both below codes to add a foreign key but given below error:
        //The ALTER TABLE statement conflicted with the FOREIGN KEY constraint "FK_Products_Categories_CategoryId". The conflict occurred in database "Bulky", table "dbo.Categories", column 'Id'.

        //public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        //public Category Category { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
    }
}
