using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DraftECommerece.Models
{
    public class tbl_Foundation_Order
    {

        public tbl_Foundation_Order()
        {
            OrderDetails = new List<tbl_Foundation_OrderDetails>();
        }

        public int Id { get; set; }
        [Display(Name ="Order No")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        
        public DateTime OrderDate { get; set; }

        public virtual List<tbl_Foundation_OrderDetails> OrderDetails { get; set; }


    }
}
