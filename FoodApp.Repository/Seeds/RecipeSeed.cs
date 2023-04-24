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
    public class RecipeSeed : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            //builder.HasData(
            //    new Recipe 
            //    { 
            //        Id=1,
            //        Title = "Domates Corba",
            //        CategoryId = 1,
                    
            //    },
            //    new Recipe 
            //    { 
            //        Id=2, 
            //        Title = "Fettucini Alfredo",
            //        CategoryId = 3,
            //    },
            //    new Recipe 
            //    { 
            //        Id=3, 
            //        Title = "Beyti",
            //        CategoryId= 4,
            //    },
            //    new Recipe 
            //    { 
            //        Id=4, 
            //        Title = "İskender" ,
            //        CategoryId=4
            //    }

            //    );
        }
    }
}
