using DemoPatterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Builder
{
    public class BuilderClientCode
    {
        public static void Test()
        {
            IHouseBuilder builder = BuilderExtension.GetBuilder(HouseType.Modern);
            var director = new Director(builder);
            director.BuildHouse();
            var house = builder.GetResult();
            Console.WriteLine($"Walls: {house.Walls}, roof: {house.Roof}");
        }
    }
}
