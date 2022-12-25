using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DraftECommerece.Models
{
    public partial class tbl_Foundation_Roles
    {
        public tbl_Foundation_Roles()
        {
            TblFoundationRoleClaims = new HashSet<tbl_Foundation_RoleClaims>();
            TblFoundationUserRoles = new HashSet<tbl_Foundation_UserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<tbl_Foundation_RoleClaims> TblFoundationRoleClaims { get; set; }
        public virtual ICollection<tbl_Foundation_UserRoles> TblFoundationUserRoles { get; set; }
    }
}
