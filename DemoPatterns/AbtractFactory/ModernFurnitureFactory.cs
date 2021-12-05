using DemoPatterns.AbtractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.AbtractFactory
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
