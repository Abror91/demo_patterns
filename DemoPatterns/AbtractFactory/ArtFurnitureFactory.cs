using DemoPatterns.AbtractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.AbtractFactory
{
    public class ArtFurnitureFactory : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ArtChair();
        }

        public override ICoffeeTable CreateCoffeeTable()
        {
            return new ArtCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new ArtSofa();
        }
    }
}
