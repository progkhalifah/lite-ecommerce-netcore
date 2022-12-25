using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DraftECommerece.Models
{
    public class tbl_Foundation_Products
    {

        
        public int Id { get; set; }

        [Required]
        public string NameProduct { get; set; }

        [Required]
        public decimal PriceProduct { get; set; }

        public string ImageProduct { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile UploadImageProduct { get; set; }

        [Display(Name ="Product Color")]
        public string ProductColor { get; set; }

        [Required]
        [Display(Name ="Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]

        public tbl_Foundation_ProductTypes ProductTypes { get; set; }




    }
}
