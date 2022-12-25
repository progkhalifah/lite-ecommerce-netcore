using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DraftECommerece.Models
{
    public partial class tbl_Foundation_UserRoles
    {
       
        public int Id { get; set; }

        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual tbl_Foundation_Roles Role { get; set; }
        public virtual tbl_Foundation_Users User { get; set; }
    }
}
