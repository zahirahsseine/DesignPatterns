public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print(string content) => Console.WriteLine("Printing: " + content);
    public void Scan(string document) => Console.WriteLine("Scanning: " + document);
}