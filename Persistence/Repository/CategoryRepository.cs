using CoreApp.Domain.Repositories;
using CoreApp.Persistence.Context;
using CoreApp.Domain.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreApp.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Category.ToListAsync();
        }
    }



}