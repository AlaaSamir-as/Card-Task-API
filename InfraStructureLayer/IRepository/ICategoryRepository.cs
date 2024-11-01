using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructureLayer.IRepository
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategoriesAsync();
    }
}
