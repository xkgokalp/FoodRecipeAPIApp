using FoodApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class RecipeDto : BaseDto
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }

        public UserDto User { get; set; }

        public CategoryDto Category { get; set; }

        public ICollection<CommentDto> Comments { get; set; }

        public bool isDeleted { get; set; }
    }
}
