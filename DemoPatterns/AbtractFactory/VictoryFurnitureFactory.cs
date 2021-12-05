using DemoPatterns.AbtractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.AbtractFactory
{
    public class VictoryFurnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new VictorianChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
