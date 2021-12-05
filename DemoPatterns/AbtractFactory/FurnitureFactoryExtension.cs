using DemoPatterns.AbtractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.AbtractFactory
{
    public static class FurnitureFactoryExtension
    {
        public static FurnitureFactory GetFactory(FurnitureType type)
        {
            FurnitureFactory factory;
            switch (type)
            {
                case FurnitureType.Modern:
                    factory = new ModernFurnitureFactory();
                    break;
                case FurnitureType.Victorian:
                    factory = new VictoryFurnitureFactory();
                    break;
                case FurnitureType.Art:
                    factory = new ArtFurnitureFactory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
            return factory;
        }
    }
}
