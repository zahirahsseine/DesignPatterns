
var cart = new ShoppingCart();

cart.SetPaymentStrategy(new CreditCardPayment());
cart.Checkout(100.00m); // Paid using Credit Card

cart.SetPaymentStrategy(new PayPalPayment());
cart.Checkout(250.00m); // Paid using PayPal

cart.SetPaymentStrategy(new BankTransferPayment());
cart.Checkout(500.00m); // Paid using Bank Transfer