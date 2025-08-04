public class FundsCheck
{
    private double _balance = 1000.0;

    public bool HaveEnoughMoney(double amount)
    {
        return amount <= _balance;
    }

    public void DecreaseBalance(double amount)
    {
        _balance -= amount;
        Console.WriteLine($"Withdrawal complete. Remaining balance: {_balance}");
    }
}