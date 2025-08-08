// Low-level module (detail)
public class EmailService : IMessageService
{
    public void SendMessage(string message) =>
        Console.WriteLine("Email sent: " + message);
}