using PotterShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PotterShoppingCart.Controllers
{
    public class HomeController : Controller
    {

        //
        public ActionResult ShoppingCart(BookOrders bookOrders)
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();

            bookOrders.Amount = 100;
            bookOrders.Number = 1;
            int TotalFee = shoppingCartService.BuyBooks(bookOrders);


            return View();
        }
    }
}