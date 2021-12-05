using System.Collections.Generic;

namespace DemoPatterns.Command
{
    public interface IOrderCommand
    {
        void Execute(List<MenuItem> items, MenuItem item);
    }
}
