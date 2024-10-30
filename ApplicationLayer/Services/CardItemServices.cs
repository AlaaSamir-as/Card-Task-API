using ApplicationLayer.IServices;
using DomainLayer;
using InfraStructureLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class CardItemServices : ICardItemServices
    {
        private readonly ICardItemRepository _ICardItemRepository;
        public CardItemServices(ICardItemRepository oICardItemRepository)
        {
            _ICardItemRepository = oICardItemRepository;
        }
        public async Task AddCartItem(int ProductID, int Quantity)
        {
            await _ICardItemRepository.AddCartItem(ProductID, Quantity);
        }
        public async Task<List<CartItem>> GetCartItems()
        {
            return await _ICardItemRepository.GetCartItems();
        }
        public async Task RemoveCartItem(int ProductID)
        {
            await _ICardItemRepository.RemoveCartItem(ProductID);
        }

        public async Task UpdateCartItem(int ProductID, int Quantity)
        {
            await _ICardItemRepository.UpdateCartItem(ProductID, Quantity);
        }
    }
}
