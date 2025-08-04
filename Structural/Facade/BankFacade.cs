 public class BankFacade(int accountNumber, int securityCode)
 {
     private AccountNumberCheck _accountChecker = new AccountNumberCheck();
     private SecurityCodeCheck _securityChecker = new SecurityCodeCheck();
     private FundsCheck _fundsChecker = new FundsCheck();

 
     public void WithdrawCash(double amount)
     {
         Console.WriteLine("Attempting withdrawal...");

         if (!_accountChecker.IsValidAccount(_accountNumber))
         {
             Console.WriteLine("Invalid account number.");
         }
         else if (!_securityChecker.IsValidCode(_securityCode))
         {
             Console.WriteLine("Invalid security code.");
         }
         else if (!_fundsChecker.HaveEnoughMoney(amount))
         {
             Console.WriteLine("Insufficient funds.");
         }
         else
         {
             _fundsChecker.DecreaseBalance(amount);
         }
     }
 }
