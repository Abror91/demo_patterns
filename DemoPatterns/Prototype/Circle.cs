namespace DemoPatterns.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle()
        {

        }

        public Circle(Circle circle) : base(circle)
        {

        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
