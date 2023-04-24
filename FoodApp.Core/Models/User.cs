using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Models
{
    public class User : BaseEntity
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool isDeleted { get; set; }

        public ICollection<Recipe> Recipes { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

    }
}
