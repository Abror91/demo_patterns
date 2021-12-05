namespace DemoPatterns.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {

        }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {

        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
