public class PdfExporter : IReportExporter
{
    public void Export(string content)
    {
        Console.WriteLine("Exporting to PDF: " + content);
    }
}