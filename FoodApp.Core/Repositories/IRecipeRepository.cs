using FoodApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Repositories
{
    public interface IRecipeRepository : IGenericRepository<Recipe>
    {

        Task<List<Recipe>> GetRecipesWithCategory();

        Task<Recipe> GetCategoryForRecipeByIdAsync(int recipeId);

        Task<List<Comment>> GetCommentsForRecipeByIdAsync(int recipeId);

        Task<User> GetUserForRecipeByIdAsync(int userId);


    }
}
