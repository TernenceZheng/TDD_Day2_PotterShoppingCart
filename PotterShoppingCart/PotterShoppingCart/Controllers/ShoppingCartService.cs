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

            //取出最多訂購的數量
            int bigOrderNum = bookOrders.Max(c => c.Number);

            double discount = 0;

            for (int i = bigOrderNum; i >= 1; i--)
            {
                discount = GetDiscountType(i, bookOrders);

                totoalAmount += CalAmount(discount , i, bookOrders );
            }

            return totoalAmount;
        }

        private double CalAmount(double discount ,int bigOrderNum, List<BookOrders> bookOrders)
        {

            List<BookOrders> groupBookOrder = bookOrders.Where(y => y.Number >= bigOrderNum).ToList();

            double totoalAmount = 0;

            foreach (BookOrders item in groupBookOrder)
            {
                totoalAmount += item.Amount *  1;
            }

            if (discount > 0)
            {
                totoalAmount = totoalAmount * discount;
            }

            return totoalAmount;
        }

        private double GetDiscountType(int bigOrderNum, List<BookOrders> bookOrders)
        {
            //最後折扣額度
            double discount = 1;

            //總共有多少本不同的書冊
            int diffBookNum = 0;

            diffBookNum = bookOrders.Where(y => y.Number >= bigOrderNum).Select(x => x.BookName).Distinct().Count();

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

            return discount;
        }
    }
}