﻿using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructureLayer.IRepository
{
    public interface ICardItemRepository
    {
        public Task<List<CartItem>> GetCartItems();
        public Task AddCartItem(int ProductID , int Quantity);
        public Task UpdateCartItem(int ProductID , int Quantity);
        public Task RemoveCartItem(int ProductID);
    }
}
