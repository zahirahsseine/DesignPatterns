public class SalesReport : Report
{
    public SalesReport(IReportExporter exporter) : base(exporter) {}

    public override string GenerateContent()
    {
        return "Sales Report Content";
    }
}
