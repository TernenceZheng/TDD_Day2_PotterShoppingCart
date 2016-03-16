using System;
using PotterShoppingCart.Models;

namespace PotterShoppingCart.Controllers
{
    public class ShoppingCartService
    {
        public int BuyBooks(BookOrders bookOrders)
        {
            int totoalAmount = 0;

            totoalAmount = bookOrders.Amount * bookOrders.Number;

            return totoalAmount;
        }
    }
}