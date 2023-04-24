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
    public class CommentRepository : GenericRepository<Comment>, ICommentsRepository
    {
        public CommentRepository(FoodAppDbContext context) : base(context)
        {
        }

        //public async Task<List<Comment>> GetAllCommentsForRecipes()
        //{
        //    return await _context.Comments.Include(x => x.Recipe).ToListAsync();
        //}
    }
}
