using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ShopFinal.Models;

namespace ShopFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShopFinal.Models.Product> Product { get; set; }
        public DbSet<ShopFinal.Models.ArticleComment> ArticleComments { get; set; }
    }
}
