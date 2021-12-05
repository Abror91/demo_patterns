using DemoPatterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Builder
{
    public class ModernHouseBuilder : IHouseBuilder
    {
        private House _house { get; set; }
        public ModernHouseBuilder()
        {
            _house = new House();
        }
        public void Reset()
        {
            _house = new House();
        }
        public void BuildRoof()
        {
            _house.Roof = "Solar roof";
        }

        public void BuildWalls()
        {
            _house.Walls = "Glass and brick walls";
        }

        public House GetResult()
        {
            return _house;
        }
    }
}
