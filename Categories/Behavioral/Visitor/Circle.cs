    public class Circle : IShape
    {
        public double Radius { get; set; } = 5;

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
