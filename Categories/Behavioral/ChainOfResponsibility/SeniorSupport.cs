public class SeniorSupport : SupportHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.IssueType == "advanced")
        {
            Console.WriteLine($"Senior Support handled: {request.Message}");
        }
        else
        {
            Console.WriteLine("No handler available for this request.");
        }
    }
}
