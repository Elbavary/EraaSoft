
public class CheckingAccount : Account
{
    private static double withdrawalFee = 1.50;

    public CheckingAccount(string name = "Unnamed Checking Account", double balance = 0.0)
    {
        this.name = name;
        this.balance = balance;
    }

    public override bool Withdraw(double amount)
    {
        return base.Withdraw(amount + withdrawalFee);
    }

    public override string ToString()
    {
        return $"[CheckingAccount: {name}: {balance}]";
    }
}