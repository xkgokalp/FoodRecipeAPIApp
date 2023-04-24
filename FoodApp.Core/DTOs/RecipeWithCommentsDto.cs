using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class RecipeWithCommentsDto : RecipeDto
    {

        public List<CommentDto> Comments { get; set; }
    }
}
