public abstract class SupportHandler
{
    protected SupportHandler? nextHandler;

    public void SetNext(SupportHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void Handle(SupportRequest request);
}
