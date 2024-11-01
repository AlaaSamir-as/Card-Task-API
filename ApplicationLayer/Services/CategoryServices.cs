using ApplicationLayer.IServices;
using DomainLayer;
using InfraStructureLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _categoryRepository.GetCategoriesAsync();
        }
    }
}
