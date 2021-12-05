using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Command
{
    /// <summary>
    /// invoker class
    /// </summary>
    public class Patron
    {
        private IOrderCommand command { get; set; }
        private MenuItem menuItem { get; set; }
        private FastFoodOrder order { get; set; }
        public Patron()
        {
            order = new FastFoodOrder();
        }

        public void SetCommand(CommandType type)
        {
            command = OrderCommandFactory.CreateCommand(type);
        }

        public void SetMenuItem(MenuItem item)
        {
            menuItem = item;
        }

        public void ExecuteCommand()
        {
            order.ExecuteCommand(command, menuItem);
        }

        public void DisplayCurrentOrder()
        {
            order.DisplayOrderItems();
        }
    }
}
