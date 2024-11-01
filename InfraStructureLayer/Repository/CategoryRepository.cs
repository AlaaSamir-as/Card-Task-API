using DomainLayer;
using InfraStructureLayer.DBContext;
using InfraStructureLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructureLayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Category.ToListAsync();
        }
    }
}
