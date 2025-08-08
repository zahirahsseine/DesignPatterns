public class PaymentProcessor
{
    public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
    {
        paymentMethod.Pay(amount);
    }
}