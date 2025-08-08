public class PhoneDisplay : IObserver
{
        public void Update(float temperature)
        {
            Console.WriteLine($"[Phone] Temperature updated: {temperature}°C");
        }
}
