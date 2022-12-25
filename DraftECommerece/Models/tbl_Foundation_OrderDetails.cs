using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DraftECommerece.Models
{
    public class tbl_Foundation_OrderDetails
    {
        public int Id { get; set; }
        [Display(Name ="Order")]
        public int OrderId { get; set; }
        [Display(Name ="Product")]
        public int ProdcutId { get; set; }


        [ForeignKey("OrderId")]
        public tbl_Foundation_Order Order { get; set; }

        [ForeignKey("ProdcutId")]
        public tbl_Foundation_Products Product { get; set; }

    }
}
