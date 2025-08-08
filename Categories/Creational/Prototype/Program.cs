        var original = new Document("Resume Template", "Name: [Your Name]");
        var copy1 = original.Clone();
        var copy2 = original.Clone();

        copy1.Title = "John's Resume";
        copy1.Content = "Name: John";

        copy2.Title = "Sarah's Resume";
        copy2.Content = "Name: Sarah";

        original.Display();
        copy1.Display();
        copy2.Display();