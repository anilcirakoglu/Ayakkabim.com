using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayakkabim.com.Models;

namespace Ayakkabim.com.Data
{
    public class AyakkabimcomContext : DbContext
    {
        public AyakkabimcomContext()
        {
        }

        public AyakkabimcomContext (DbContextOptions<AyakkabimcomContext> options)
            : base(options)
        {
        }

        public DbSet<Ayakkabim.com.Models.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<User>().ToTable("User");
        }

        public DbSet<Ayakkabim.com.Models.User> User { get; set; }
        
    }
}
