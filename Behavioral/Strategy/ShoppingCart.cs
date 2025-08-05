public class ShoppingCart
{
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Checkout(decimal totalAmount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method.");
            }
            else
            {
                _paymentStrategy.Pay(totalAmount);
            }
        }
}

