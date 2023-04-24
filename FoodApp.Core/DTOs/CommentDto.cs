using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class CommentDto : BaseDto
    {
        public int UserId { get; set; }

        public int RecipesId { get; set; }

        public string UserComment { get; set; }

        public int Score { get; set; }
    }
}
