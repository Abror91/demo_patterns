using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Command
{
    public class MenuItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public MenuItem(string name, int amount, decimal price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Amount: " + Amount.ToString());
            Console.WriteLine("Price: " + Price.ToString());
        }
    }
}
