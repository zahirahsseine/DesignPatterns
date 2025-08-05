public class Document : IPrototype<Document>
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public Document Clone()
    {
        // Shallow copy (you can also implement deep copy if needed)
        return new Document(this.Title, this.Content);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}\nContent: {Content}\n");
    }
}
 