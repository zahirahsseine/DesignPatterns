Console.WriteLine("Hello, World!");
BankFacade bank = new BankFacade(123456, 1234);

bank.WithdrawCash(200);   // Valid case
bank.WithdrawCash(1000);  // Not enough funds
