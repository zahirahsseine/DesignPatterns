    public class Rectangle : IShape
    {
        public double Width { get; set; } = 4;
        public double Height { get; set; } = 6;

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
