 public class AccountNumberCheck
 {
     private readonly int _accountNumber = 123456;

     public bool IsValidAccount(int accountNumber)
     {
         return accountNumber == _accountNumber;
     }
 }