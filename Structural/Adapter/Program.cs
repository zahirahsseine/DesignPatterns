
// See https://aka.ms/new-console-template for more information
OldPaymentSystem _oldPaymentAdapter = new OldPaymentSystem();
IPaymentProcessor _paymentProcessor = new PaymentAdapter(_oldPaymentAdapter);

var platform = new PaymentSystem(_paymentProcessor);

platform.Checkout("1234-5678-9012-3456", 250.75m);