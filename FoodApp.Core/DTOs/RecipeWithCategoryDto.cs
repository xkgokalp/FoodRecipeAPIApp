using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class RecipeWithCategoryDto : RecipeDto
    {

        public CategoryDto Category { get; set; }


    }
}
