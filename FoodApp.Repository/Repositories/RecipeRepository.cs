using FoodApp.Core.Models;
using FoodApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Repository.Repositories
{
    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(FoodAppDbContext context) : base(context)
        {
        }

        public async Task<List<Recipe>> GetRecipesWithCategory()
        {
            return await _context.Recipes.Include(x => x.Category).ToListAsync();
        }

        public async Task<Recipe> GetCategoryForRecipeByIdAsync(int recipeId)
        {
            return await _context.Recipes.Include(x => x.Category).Where(x => x.CategoryId== recipeId).SingleOrDefaultAsync();
        }


        public async Task<User> GetUserForRecipeByIdAsync(int userId)
        {
            return await _context.Users.Where(x => x.Id == userId).SingleOrDefaultAsync();
        }

        public async Task<List<Comment>> GetCommentsForRecipeByIdAsync(int recipeId)
        {
            return await _context.Comments.Where(x => x.RecipesId == recipeId).ToListAsync();
        }
    }

    
}