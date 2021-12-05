using System.Collections.Generic;

namespace DemoPatterns.Command
{
    public class AddCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> items, MenuItem item)
        {
            items.Add(item);
        }
    }
}
