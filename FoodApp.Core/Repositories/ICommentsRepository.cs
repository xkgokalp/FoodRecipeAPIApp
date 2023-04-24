using FoodApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Repositories
{
    public interface ICommentsRepository : IGenericRepository<Comment>
    {
        //Task<List<Comment>> GetAllCommentsForRecipes();

    }
}
