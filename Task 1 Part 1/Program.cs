
namespace EraaSoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Khaled", 5000);
            account.Print();
            account.Deposit(2000);
            account.Print();
            account.Withdraw(4000);
            account.Print();

            Console.WriteLine("================================");

            Account khaled = new("Khaled Gamel", 12000);
            khaled.Print();
            khaled.Deposit(2000);
            khaled.Print();
            khaled.Withdraw(4000);
            khaled.Print();
        }
    }
}