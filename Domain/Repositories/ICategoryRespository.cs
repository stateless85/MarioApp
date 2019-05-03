using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApp.Domain.Models;

namespace CoreApp.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}