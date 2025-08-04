
public class EmployeeReport : Report
{
    public EmployeeReport(IReportExporter exporter) : base(exporter) {}

    public override string GenerateContent()
    {
        return "Employee Report Content";
    }
}
