using DemoPatterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Builder
{
    public class WoodHouseBuilder : IHouseBuilder
    {
        private House _house { get; set; }
        public WoodHouseBuilder()
        {
            _house = new House();
        }

        public void Reset()
        {
            _house = new House();
        }
        public void BuildRoof()
        {
            _house.Roof = "Wooden roof";
        }

        public void BuildWalls()
        {
            _house.Walls = "Wooden walls";
        }

        public House GetResult()
        {
            return _house;
        }
    }
}
