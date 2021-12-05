using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Command
{
    public class FastFoodOrder
    {
        private List<MenuItem> items { get; set; }
        public FastFoodOrder()
        {
            items = new List<MenuItem>();
        }

        public void ExecuteCommand(IOrderCommand command, MenuItem item)
        {
            command.Execute(items, item);
        }

        public void DisplayOrderItems()
        {
            foreach(var item in items)
            {
                item.Display();
            }
            Console.WriteLine("---------------------------");
        }
    }
}
