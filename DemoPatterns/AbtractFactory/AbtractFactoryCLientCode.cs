using DemoPatterns.AbtractFactory.Models;

namespace DemoPatterns.AbtractFactory
{
    public class AbtractFactoryCLientCode
    {
        public static void Test()
        {
            FurnitureFactory factory = FurnitureFactoryExtension.GetFactory(FurnitureType.Modern);
            IChair chair = factory.CreateChair();
            ISofa sofa = factory.CreateSofa();
            ICoffeeTable coffeeTable = factory.CreateCoffeeTable();
        }
    }
}
