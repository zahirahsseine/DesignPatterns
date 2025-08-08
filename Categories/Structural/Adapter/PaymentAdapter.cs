 public class PaymentAdapter(OldPaymentSystem oldPaymentSystem) : IPaymentProcessor
 {
     public void ProcessPayment(string accountNumber, decimal amount)
     {
         // Convert decimal to double for the legacy system
         double convertedAmount = (double)amount;
         oldPaymentSystem.MakePayment(accountNumber, convertedAmount);
     }
 }