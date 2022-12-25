using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DraftECommerece.Models
{
    public partial class tbl_Foundation_UserTokens
    {
        [Key]
        public string UserId { get; set; }

        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual tbl_Foundation_Users User { get; set; }
    }
}
