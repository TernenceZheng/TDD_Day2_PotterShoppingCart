using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Controllers;
using PotterShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        /// <summary>
        /// Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元
        /// </summary>
        [TestMethod()]
        public void Test_第一集買了一本_價格為100()
        {
            //arrange
            List<BookOrders> orderList = new List<BookOrders>();
            orderList.Add(new BookOrders() { BookName = "第一冊", Amount = 100, Number = 1 });

            var target = new ShoppingCartService();

            var expected = 100;

            //act r
            var actual = target.BuyBooks(orderList);

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Scenario: 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        /// </summary>
        [TestMethod()]
        public void Test_第一集買了一本第二集也買了一本_價格為190()
        {
            //arrange
            //BookOrders bookOrders = new BookOrders() { Amount = 100, Number = 1 };
            //改為List，並且BookOrders多加 BookName 屬性
            List<BookOrders> orderList = new List<BookOrders>();
            orderList.Add(new BookOrders() { BookName = "第一冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第二冊", Amount = 100, Number = 1 });
            var target = new ShoppingCartService();

            var expected = 190;

            //act
            var actual = target.BuyBooks(orderList);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}