using System;
using PotterShoppingCart.Models;
using System.Collections.Generic;

namespace PotterShoppingCart.Controllers
{
    public class ShoppingCartService
    {
        public double BuyBooks(List<BookOrders> bookOrders)
        {
            double totoalAmount = 0;

            foreach (BookOrders item in bookOrders)
            {
                totoalAmount = item.Amount * item.Number;
            }

            totoalAmount = totoalAmount * 0.95;

            return totoalAmount;
        }
    }
}