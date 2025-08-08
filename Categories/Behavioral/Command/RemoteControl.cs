    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PresButton()
        {
            _command.Execute();
        }
    }
