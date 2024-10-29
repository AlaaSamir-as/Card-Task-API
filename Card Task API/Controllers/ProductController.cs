using ApplicationLayer.IServices;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Card_Task_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _IProductService;
        public ProductController(IProductService oIProductService)
        {
            _IProductService = oIProductService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProduct(int Page = 1 , int PageSize =10)
        {
            List<Product> products = new List<Product>();
            products =await _IProductService.GetProductsAsync(Page, PageSize);
            return Ok(products);
        }
    }
}
