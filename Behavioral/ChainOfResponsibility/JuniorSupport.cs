public class JuniorSupport : SupportHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.IssueType == "intermediate")
        {
            Console.WriteLine($"Junior Support handled: {request.Message}");
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(request);
        }
        else
        {
            Console.WriteLine("No handler available for this request.");
        }
    }
}
