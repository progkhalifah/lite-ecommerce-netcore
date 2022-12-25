using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DraftECommerece.Models
{
    public partial class tbl_Foundation_Users
    {
        public tbl_Foundation_Users()
        {
            TblFoundationUserClaims = new HashSet<tbl_Foundation_UserClaims>();
            /*TblFoundationUserLogins = new HashSet<TblFoundationUserLogins>();*/
            TblFoundationUserRoles = new HashSet<tbl_Foundation_UserRoles>();
            TblFoundationUserTokens = new HashSet<tbl_Foundation_UserTokens>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<tbl_Foundation_UserClaims> TblFoundationUserClaims { get; set; }
        /*public virtual ICollection<TblFoundationUserLogins> TblFoundationUserLogins { get; set; }*/
        public virtual ICollection<tbl_Foundation_UserRoles> TblFoundationUserRoles { get; set; }
        public virtual ICollection<tbl_Foundation_UserTokens> TblFoundationUserTokens { get; set; }
    }
}
