using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.ChainOfResponsibility
{
    public class PurchaseOrder
    {
        public PurchaseOrder(int purchaseNumber, int amount, decimal price, string name)
        {
            PurchaseNumber = purchaseNumber;
            Amount = amount;
            Price = price;
            Name = name;
            TotalCost = amount * price;

            Console.WriteLine("Purchase request for " + name
                          + " (" + amount + " for $"
                          + price.ToString() + ") has been submitted.");
        }
        public int PurchaseNumber { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public decimal TotalCost { get; set; }
    }
}
