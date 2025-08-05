public class ChatBotSupport : SupportHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.IssueType == "basic")
        {
            Console.WriteLine($"ChatBot handled: {request.Message}");
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
