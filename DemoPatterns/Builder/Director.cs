using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Builder
{
    public class Director
    {
        private IHouseBuilder _builder { get; set; }
        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void BuildHouse()
        {
            _builder.BuildWalls();
            _builder.BuildRoof();
        }
    }
}
