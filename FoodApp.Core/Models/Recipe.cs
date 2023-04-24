using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Models
{
    public class Recipe : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }
       
        public bool isDeleted { get; set; }

        public Category Category { get; set; }

        public User User { get; set; }


        public ICollection<Comment> Comments { get; set; }

        public ICollection<Favorite> Favorites { get; set; }
        
    }
}
