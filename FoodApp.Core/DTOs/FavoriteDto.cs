using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class FavoriteDto : BaseDto
    {
        public int UserId { get; set; }

        public int RecipesId { get; set; }
    }
}
