public class PaymentSystem(IPaymentProcessor paymentProcessor) 
{
    public void Checkout(string accountNumber, decimal amount)
    {
        paymentProcessor.ProcessPayment(accountNumber, amount);
    }
}