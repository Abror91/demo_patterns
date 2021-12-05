using DemoPatterns.AbtractFactory.Models;

namespace DemoPatterns.AbtractFactory
{
    public abstract class FurnitureFactory
    {
        public abstract IChair CreateChair();
        public abstract ISofa CreateSofa();
        public abstract ICoffeeTable CreateCoffeeTable();
    }
}
