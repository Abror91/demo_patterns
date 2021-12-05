using System.Collections.Generic;
using System.Linq;

namespace DemoPatterns.Command
{
    public class EditCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> items, MenuItem item)
        {
            var editItem = items.Where(s => s.Name == item.Name).First();
            editItem.Amount = item.Amount;
            editItem.Price = item.Price;
        }
    }
}
