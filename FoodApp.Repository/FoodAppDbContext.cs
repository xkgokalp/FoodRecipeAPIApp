using FoodApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Repository
{
    public class FoodAppDbContext : DbContext
    {
       
        public FoodAppDbContext(DbContextOptions<FoodAppDbContext> options) : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Favorite> Favorites { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=ISTN30107\SQLEXPRESS; Database=FoodAppDB; User ID =xkgokalp; Password=1234; Trusted_Connection=True;TrustServerCertificate=True; MultipleActiveResultSets=true");
            }



           
        }




    }
}
