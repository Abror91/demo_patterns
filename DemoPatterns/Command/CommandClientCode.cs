using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Command
{
    public class CommandClientCode
    {
        public static void Test()
        {
            var patron = new Patron();
            patron.SetCommand(CommandType.Add);
            patron.SetMenuItem(new MenuItem("burgers", 5, 10));
            patron.ExecuteCommand();
            patron.DisplayCurrentOrder();

            patron.SetCommand(CommandType.Add);
            patron.SetMenuItem(new MenuItem("french fries", 2, 2));
            patron.ExecuteCommand();
            patron.DisplayCurrentOrder();

            patron.SetCommand(CommandType.Edit);
            patron.SetMenuItem(new MenuItem("burgers", 10, 7.5m));
            patron.ExecuteCommand();
            patron.DisplayCurrentOrder();

            patron.SetCommand(CommandType.Remove);
            patron.SetMenuItem(new MenuItem("french fries", 2, 2));
            patron.ExecuteCommand();
            patron.DisplayCurrentOrder();
        }
    }
}
