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
    public class FavoriteRepository : GenericRepository<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(FoodAppDbContext context) : base(context)
        {
        }

        public async Task<List<Favorite>> GetFavoriteAsync(int favoriteId)
        {
            return await _context.Favorites.Where(x => x.Id == favoriteId).ToListAsync();
        }
    }
}
