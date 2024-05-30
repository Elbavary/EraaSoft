using System;

public class TrustAccount : SavingsAccount
{
    private int withdrawalCount;
    private int maxWithdrawals = 3;
    private double bonusThreshold = 5000.0;
    private double bonusAmount = 50.0;
    private double maxWithdrawalPercentage = 0.2;

    public TrustAccount(string name = "Unnamed Trust Account", double balance = 0.0, double interestRate = 0.0)
    {
        withdrawalCount = 0;
    }

    public override bool Deposit(double amount)
    {
        if (amount >= bonusThreshold)
        {
            amount += bonusAmount;
        }
        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {
        if (withdrawalCount >= maxWithdrawals || amount > GetBalance() * maxWithdrawalPercentage)
        {
            return false;
        }
        else
        {
            if (base.Withdraw(amount))
            {
                withdrawalCount++;
                return true;
            }
            return false;
        }
    }

    public override string ToString()
    {
        return $"[TrustAccount: {name}: {balance}, {interestRate}%, Withdrawals: {withdrawalCount}/{maxWithdrawals}]";
    }
}
