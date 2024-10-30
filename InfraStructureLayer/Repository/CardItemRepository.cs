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
    public class CardItemRepository : ICardItemRepository
    {
        private readonly AppDbContext _context;
        public CardItemRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddCartItem(int ProductID, int Quantity)
        {
            CartItem CartItem = await _context.CartItem.FindAsync(ProductID);
            if (CartItem == null) {
                CartItem = new CartItem() { ProductId =ProductID,Quantity =Quantity };
                _context.CartItem.Add(CartItem);
            }
            else
            {
                CartItem.Quantity += Quantity;
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            return await _context.CartItem.ToListAsync();
        }

        public async Task RemoveCartItem(int ProductID)
        {
            CartItem CartItem = await _context.CartItem.FirstOrDefaultAsync(c => c.ProductId == ProductID);
            if (CartItem != null) 
            {
                _context.CartItem.Remove(CartItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateCartItem(int ProductID, int Quantity)
        {
            CartItem CartItem = await _context.CartItem.FirstOrDefaultAsync(c=>c.ProductId== ProductID);
            if (CartItem != null)
            {
                CartItem.Quantity = Quantity;
                await _context.SaveChangesAsync();
            }
        }
    }
}
