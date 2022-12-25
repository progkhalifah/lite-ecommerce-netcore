using DraftECommerece.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DraftECommerece.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<tbl_Foundation_ProductTypes> tbl_Foundation_ProductTypes { get; set; }
        
        public DbSet<tbl_Foundation_Products> tbl_Foundation_Products { get; set; }

        public DbSet<tbl_Foundation_Order> tbl_Foundation_Order { get; set; }

        public DbSet<tbl_Foundation_OrderDetails> tbl_Foundation_OrderDetails { get; set; }

        public DbSet<tbl_Foundation_Users> tbl_Foundation_Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<tbl_Foundation_Users>().ToTable("tbl_Foundation_Users");
            builder.Entity<IdentityRole>().ToTable("tbl_Foundation_Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("tbl_Foundation_UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("tbl_Foundation_UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("tbl_Foundation_UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("tbl_Foundation_RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("tbl_Foundation_UserTokens");

            

        }

    }
}
