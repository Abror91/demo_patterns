using DemoPatterns.Builder.Models;

namespace DemoPatterns.Builder
{
    public interface IHouseBuilder
    {
        void Reset();
        void BuildWalls();
        void BuildRoof();
        House GetResult();
    }
}
