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

        
        public ActionResult ShoppingCart()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShoppingCart(List<BookOrders> bookOrders)
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();
            double TotalFee = shoppingCartService.BuyBooks(bookOrders);


            return View();
        }
    }
}