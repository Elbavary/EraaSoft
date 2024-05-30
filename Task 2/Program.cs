
class Program
{
    static void Main()
    {
        // Accounts
        var accounts = new List<Account>
        {
            new Account(),
            new Account("Larry"),
            new Account("Moe", 2000),
            new Account("Curly", 5000)
        };

        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Withdraw(accounts, 2000);

        // Savings Accounts
        var savAccounts = new List<Account>
        {
            new SavingsAccount(),
            new SavingsAccount("Superman"),
            new SavingsAccount("Batman", 2000),
            new SavingsAccount("Wonderwoman", 5000, 5.0)
        };

        AccountUtil.Display(savAccounts);
        AccountUtil.Deposit(savAccounts, 1000);
        AccountUtil.Withdraw(savAccounts, 2000);

        // Checking Accounts
        var checAccounts = new List<Account>
        {
            new CheckingAccount(),
            new CheckingAccount("Larry2"),
            new CheckingAccount("Moe2", 2000),
            new CheckingAccount("Curly2", 5000)
        };

        AccountUtil.Display(checAccounts);
        AccountUtil.Deposit(checAccounts, 1000);
        AccountUtil.Withdraw(checAccounts, 2000);
        AccountUtil.Withdraw(checAccounts, 2000);

        // Trust Accounts
        var trustAccounts = new List<Account>
        {
            new TrustAccount(),
            new TrustAccount("Superman2"),
            new TrustAccount("Batman2", 2000),
            new TrustAccount("Wonderwoman2", 5000, 5.0)
        };

        AccountUtil.Display(trustAccounts);
        AccountUtil.Deposit(trustAccounts, 1000);
        AccountUtil.Deposit(trustAccounts, 6000);
        AccountUtil.Withdraw(trustAccounts, 2000);
        AccountUtil.Withdraw(trustAccounts, 3000);
        AccountUtil.Withdraw(trustAccounts, 500);

        // Testing operator overloading
        Account acc1 = new Account("Account1", 1500);
        Account acc2 = new Account("Account2", 2000);
        Account combinedAccount = acc1 + acc2;
        Console.WriteLine($"Combined Account: {combinedAccount}");

        Console.WriteLine();
    }
}
