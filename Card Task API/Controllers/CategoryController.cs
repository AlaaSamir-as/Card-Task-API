using ApplicationLayer.IServices;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Card_Task_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _ICategoryServices;
        public CategoryController(ICategoryServices categoryServices )
        {
            _ICategoryServices = categoryServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            List<Category> categories = await _ICategoryServices.GetCategoriesAsync();
            return Ok(categories);
        }
    }
}
