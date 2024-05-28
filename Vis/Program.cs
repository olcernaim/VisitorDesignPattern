﻿using System;

namespace Vis
{
    class Program
    {
        static void Main(string[] args)
        {

            ItemElement[] items = new ItemElement[]{new Book(20, "1234"),
                              new Book(100, "5678"), new Fruit(10, 2, "Banana"),
                              new Fruit(5, 5, "Apple")};

            int total = calculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        private static int calculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.accept(visitor);
            }
            return sum;
        }
    }
}
