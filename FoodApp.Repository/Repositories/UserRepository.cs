using FoodApp.Core.Models;
using FoodApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(FoodAppDbContext context) : base(context)
        {
        }

        public async Task<List<User>> GetAllUsersWithRecipe(int userId)
        {
           return await _context.Users.Include(x => x.Recipes).Where(x => x.Id == userId ).ToListAsync();
        }
    }
}
