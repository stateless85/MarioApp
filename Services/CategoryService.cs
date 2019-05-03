using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApp.Domain.Services;
using CoreApp.Domain.Models;
using CoreApp.Domain.Repositories;


namespace CoreApp.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _iCategoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _iCategoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _iCategoryRepository.ListAsync();
        }
    }
}