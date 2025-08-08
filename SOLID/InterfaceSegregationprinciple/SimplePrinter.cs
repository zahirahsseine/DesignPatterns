public class SimplePrinter : IPrinter
{
    public void Print(string content) => Console.WriteLine("Printing: " + content);
}