using System;
using PotterShoppingCart.Models;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.Controllers
{
    public class ShoppingCartService
    {
        public double BuyBooks(List<BookOrders> bookOrders)
        {
            double totoalAmount = 0;

            //最後折扣額度
            double discount = 0;

            //總共有多少本不同的書冊
            int diffBookNum = 0;

            diffBookNum = bookOrders.Select(x => x.BookName).Distinct().Count();

            //兩本不同的書，則會有5%的折扣
            switch (diffBookNum)
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.90;
                    break;
                case 4:
                    discount = 0.80;
                    break;
                case 5:
                    discount = 0.75;
                    break;
                default:
                    break;
            }

            foreach (BookOrders item in bookOrders)
            {
                totoalAmount += item.Amount * item.Number;
            }

            if (discount > 0)
            {
                totoalAmount = totoalAmount * discount;
            }


            return totoalAmount;
        }
    }
}