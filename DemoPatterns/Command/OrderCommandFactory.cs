using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Command
{
    public class OrderCommandFactory
    {
        public static IOrderCommand CreateCommand(CommandType type)
        {
            IOrderCommand command;
            switch (type)
            {
                case CommandType.Add:
                    command = new AddCommand();
                    break;
                case CommandType.Remove:
                    command = new RemoveComand();
                    break;
                case CommandType.Edit:
                    command = new EditCommand();
                    break;
                default:
                    command = new AddCommand();
                    break;
            }
            return command;
        }
    }
}
