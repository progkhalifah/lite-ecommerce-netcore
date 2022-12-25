using System.ComponentModel.DataAnnotations;

namespace DraftECommerece.Models
{
    public class tbl_Foundation_ProductTypes
    {

        
        public int Id { get; set; }

        [Required]
        [Display(Name ="Product Type")]
        public string ProductType { get; set; }


    }
}
