 public interface IPaymentProcessor
 {
     void ProcessPayment(string accountNumber, decimal amount);
 }