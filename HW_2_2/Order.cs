﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class Order
    {
        public static void OrderProcess()
        {
            Console.WriteLine("You order:");
            Console.WriteLine("Order number: " + OrderNumber());
            Cart.CartReader();
            Console.WriteLine("Buyer information:");
            Console.WriteLine(Customers._costumer);

        }

        private static int OrderNumber()
        {
            Random rand = new Random();
            return rand.Next(100000,999999);
        }
    }
}
