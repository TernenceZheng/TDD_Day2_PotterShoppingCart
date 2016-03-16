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
            BookOrders bookOrders = new BookOrders() { Amount = 100, Number = 1 };

            var target = new ShoppingCartService();

            var expected = 100;

            //act r
            var actual = target.BuyBooks(bookOrders);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}