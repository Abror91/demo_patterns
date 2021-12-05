using DemoPatterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Builder
{
    public static class BuilderExtension
    {
        public static IHouseBuilder GetBuilder(HouseType type)
        {
            IHouseBuilder builder;
            switch (type)
            {
                case HouseType.Wooden:
                    builder = new WoodHouseBuilder();
                    break;
                case HouseType.Modern:
                    builder = new ModernHouseBuilder();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
            return builder;
        }
    }
}
