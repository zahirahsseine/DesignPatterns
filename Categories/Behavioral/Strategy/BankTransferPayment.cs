public class BankTransferPayment : IPaymentStrategy
{
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
}
