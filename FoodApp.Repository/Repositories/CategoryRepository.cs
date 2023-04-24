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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FoodAppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithRecipesAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Recipes).Where(x => x.Id == categoryId).SingleOrDefaultAsync();

        }
    }
}
