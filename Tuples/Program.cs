using System;
using System.Collections.Generic;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("skirt", 39.50, 1));
            transactions.Add(("book", 15, 2));
            transactions.Add(("ipod", 200, 1));
            transactions.Add(("pants", 34.90, 6));
            transactions.Add(("laptop", 12000, 1));

            double totalRevenue = 0;
            int totalProduct = 0;

            foreach ((string products, double amount, int quantity) item in transactions)
            {
                totalRevenue += item.amount;
                totalProduct += item.quantity;
               
            }
            
            Console.WriteLine($"You have sold {totalRevenue} and {totalProduct}" );
            Console.ReadLine();
        }
    }
}
