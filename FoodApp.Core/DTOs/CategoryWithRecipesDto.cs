using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class CategoryWithRecipesDto : CategoryDto
    {
        public List<RecipeDto> Recipes { get; set; }

    }
}
