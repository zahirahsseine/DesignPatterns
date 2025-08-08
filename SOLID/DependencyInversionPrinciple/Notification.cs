// High-level module
public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Send(string content)
    {
        _messageService.SendMessage(content);
    }
}