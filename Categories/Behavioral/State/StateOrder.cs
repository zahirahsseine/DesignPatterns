public class StateOrder
{
    private  IOrderState _state;
    public StateOrder()
    {
        _state = new NewState();
    }
    
    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state.State;
    }
}