using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.IServices
{
    public interface ICategoryServices
    {
        public Task<List<Category>> GetCategoriesAsync();
    }
}
