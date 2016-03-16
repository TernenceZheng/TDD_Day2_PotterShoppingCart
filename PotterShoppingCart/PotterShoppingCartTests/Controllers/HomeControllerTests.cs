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

        /// <summary>
        /// Scenario: 一二三集各買了一本，價格應為100*3*0.9=270
        /// </summary>
        [TestMethod()]
        public void Test_一二三集各買了一本_價格為270()
        {
            //arrange
            List<BookOrders> orderList = new List<BookOrders>();
            orderList.Add(new BookOrders() { BookName = "第一冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第二冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第三冊", Amount = 100, Number = 1 });
            var target = new ShoppingCartService();

            var expected = 270;

            //act
            var actual = target.BuyBooks(orderList);

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Scenario: 一二三四集各買了一本，價格應為100*4*0.8=320
        /// </summary>
        [TestMethod()]
        public void Test_一二三四集各買了一本_價格為320()
        {
            //arrange
            List<BookOrders> orderList = new List<BookOrders>();
            orderList.Add(new BookOrders() { BookName = "第一冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第二冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第三冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第四冊", Amount = 100, Number = 1 });
            var target = new ShoppingCartService();

            var expected = 320;

            //act
            var actual = target.BuyBooks(orderList);

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Scenario: 一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
        /// </summary>
        [TestMethod()]
        public void Test_一次買了整套_價格為375()
        {
            //arrange
            List<BookOrders> orderList = new List<BookOrders>();
            orderList.Add(new BookOrders() { BookName = "第一冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第二冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第三冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第四冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第五冊", Amount = 100, Number = 1 });
            var target = new ShoppingCartService();

            var expected = 375;

            //act
            var actual = target.BuyBooks(orderList);

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Scenario: 一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
        /// </summary>
        [TestMethod()]
        public void Test_一二集各買了一本第三集買了兩本_價格為370()
        {
            //arrange
            List<BookOrders> orderList = new List<BookOrders>();
            orderList.Add(new BookOrders() { BookName = "第一冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第二冊", Amount = 100, Number = 1 });
            orderList.Add(new BookOrders() { BookName = "第三冊", Amount = 100, Number = 2 });

            var target = new ShoppingCartService();

            var expected = 370;

            //act
            var actual = target.BuyBooks(orderList);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}