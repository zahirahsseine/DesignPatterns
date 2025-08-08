    public class DrawingVisitor : IShapeVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine($"Drawing a circle with radius {circle.Radius}");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine($"Drawing a rectangle with width {rectangle.Width} and height {rectangle.Height}");
        }
    }
    