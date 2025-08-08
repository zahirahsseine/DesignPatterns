public class WindowDisplay : IObserver
{
        public void Update(float temperature)
        {
            Console.WriteLine($"[Window] Temperature updated: {temperature}°C");
        }
}
