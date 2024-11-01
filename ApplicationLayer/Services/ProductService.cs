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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _IProductRepository;
        public ProductService(IProductRepository oIProductRepository)
        {
            _IProductRepository = oIProductRepository;
        }
        public async Task<List<Product>> GetProductsAsync(int Page, int PageSize, int CategoryID)
        {
            return await _IProductRepository.GetProductsAsync(Page, PageSize, CategoryID);
        }
    }
}
