namespace DemoPatterns.Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Shape()
        {

        }

        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
        }

        public abstract Shape Clone();
    }
}
