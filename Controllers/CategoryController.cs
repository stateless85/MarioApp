using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CoreApp.Domain.Services;
using CoreApp.Domain.Models;

namespace CoreApp.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class CategoryController :Controller
    {
        private readonly ICategoryService _icategoryService;

        public CategoryController(ICategoryService icategoryService)
        {
            _icategoryService = icategoryService;
        }

        [HttpGet]
        [Route("api/getAll")]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _icategoryService.ListAsync();
            return categories;
        }
    }
}