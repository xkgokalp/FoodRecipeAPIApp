using FoodApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly FoodAppDbContext _context;

        public UnitOfWork(FoodAppDbContext context)
        {
            _context=context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
