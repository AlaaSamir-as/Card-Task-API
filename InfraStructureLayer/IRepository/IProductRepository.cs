using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructureLayer.IRepository
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProductsAsync(int Page , int PageSize);
    }
}
