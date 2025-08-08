   var processor = new PaymentProcessor();

   processor.ProcessPayment(new CreditCardPayment(), 100);
   processor.ProcessPayment(new PayPalPayment(), 200);
