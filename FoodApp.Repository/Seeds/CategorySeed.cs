using FoodApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id=1, Name = "Corbalar"},
                new Category { Id=2, Name = "Aperatifler" },
                new Category { Id=3, Name = "Makarnalar" },
                new Category { Id=4, Name = "EtliYemekler" }

                );
        }
    }
}
