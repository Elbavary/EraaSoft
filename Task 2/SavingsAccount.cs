
public class SavingsAccount : Account
{
    protected double interestRate;

    public SavingsAccount(string name = "Unnamed Savings Account", double balance = 0.0, double interestRate = 0.0)
    {
        this.interestRate = interestRate;
    }

    public override string ToString()
    {
        return $"[SavingsAccount: {name}: {balance}, {interestRate}%]";
    }
}
