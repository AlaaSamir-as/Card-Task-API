using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.IServices
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductsAsync(int Page, int PageSize);
    }
}
