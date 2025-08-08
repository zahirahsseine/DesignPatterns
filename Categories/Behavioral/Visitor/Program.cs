        // Create shapes
        List<IShape> shapes = new List<IShape>
        {
            new Circle { Radius = 7 },
            new Rectangle { Width = 10, Height = 5 }
        };

        // Create a visitor
        IShapeVisitor drawingVisitor = new DrawingVisitor();

        // Apply the visitor to each shape
        foreach (var shape in shapes)
        {
            shape.Accept(drawingVisitor);
        }