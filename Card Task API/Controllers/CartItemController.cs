using ApplicationLayer.IServices;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Card_Task_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly ICardItemServices _ICardItemServices;
        public CartItemController(ICardItemServices oICardItemServices)
        {
            _ICardItemServices = oICardItemServices;
        }
        [HttpGet]
        public async Task<List<CartItem>> GetCartItems()
        {
            return await _ICardItemServices.GetCartItems();
        }

        [HttpPost("{productId}")]
        public async Task<IActionResult> AddCartItem(int productId, int quantity)
        {
            await _ICardItemServices.AddCartItem(productId, quantity);
            return Ok();
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateCartItem(int productId, int quantity)
        {
            await _ICardItemServices.UpdateCartItem(productId, quantity);
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> RemoveCartItem(int productId)
        {
            await _ICardItemServices.RemoveCartItem(productId);
            return NoContent();
        }

    }
}
