using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApp.Domain.Models;

namespace CoreApp.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();   
    }
}