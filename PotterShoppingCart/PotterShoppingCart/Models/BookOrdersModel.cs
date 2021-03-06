﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PotterShoppingCart.Models
{
    public class BookOrders
    {

        /// <summary>
        /// 書本名稱
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 訂購數量
        /// </summary>
        public int Number { get; set; }

    }
}