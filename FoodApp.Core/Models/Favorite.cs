using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Models
{
    public class Favorite : BaseEntity
    {

        public int UserId { get; set; }

        public int RecipesId { get; set; }

        public User User { get; set; }

        public Recipe Recipe { get; set; }

    }
}
