using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPatterns.Command
{
    public class RemoveComand : IOrderCommand
    {
        public void Execute(List<MenuItem> items, MenuItem item)
        {
            items.Remove(items.Where(s => s.Name == item.Name).First());
        }
    }
}
