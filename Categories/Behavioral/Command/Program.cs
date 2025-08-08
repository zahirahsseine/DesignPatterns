Light light = new Light();

ICommand turnOn = new TurnOnCommand(light);
ICommand turnOff = new TurnOffCommand(light);

RemoteControl remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PresButton();

remote.SetCommand(turnOff);
remote.PresButton();