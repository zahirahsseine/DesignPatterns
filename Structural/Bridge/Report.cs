public abstract class Report(IReportExporter reportExporter)
{
    public abstract string GenerateContent();

    public void Export()
    {
        string content = GenerateContent();
        reportExporter.Export(content);
    }
}