WeatherStation station = new();
var phoneDisplay = new PhoneDisplay();
var windowDisplay = new WindowDisplay();

station.Attach(PhoneDisplay);
station.Attach(WindowDisplay);

station.SetTemperature(22.5f);
station.SetTemperature(24.0f);
