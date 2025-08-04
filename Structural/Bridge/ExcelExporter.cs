public class ExcelExporter : IReportExporter
{
    public void Export(string content)
    {
        Console.WriteLine("Exporting to Excel: " + content);
    }
}