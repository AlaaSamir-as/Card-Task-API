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
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetProductsAsync(int Page, int PageSize)
        {
           return await _context.Product.Skip((Page-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
