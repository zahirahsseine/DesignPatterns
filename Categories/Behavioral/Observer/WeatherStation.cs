public class WeatherStation : ISubject
{
        private List<IObserver> _observers = new();
        private float _temperature;

        public void SetTemperature(float temp)
        {
            Console.WriteLine($"\nTemperature changed to {temp}°C");
            _temperature = temp;
            Notify();
        }

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
}