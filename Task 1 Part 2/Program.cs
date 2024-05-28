
using System.Security.Principal;

namespace EraaSoft
{
    internal class Program
    {
        public enum UserOption
        {
            Withdraw = 1,
            Deposit,
            Print,
            Quit
        }
        static void Main(string[] args)
        {
            Account account = new Account("Khaled", 5000);

            UserOption selectedOption = ReadUserOption();

            switch (selectedOption)
            {
                case UserOption.Withdraw:
                    Console.WriteLine("You selected Withdraw");
                    DoWithdraw(account);
                    break;
                case UserOption.Deposit:
                    Console.WriteLine("You selected Deposit");
                    DoDeposit(account);
                    break;
                case UserOption.Print:
                    Console.WriteLine("You selected Print");
                    DoPrint(account);
                    break;
                case UserOption.Quit:
                    Console.WriteLine("You selected Quit");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
        private static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter amount to deposit:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(amount);
            account.Print();
        }

        private static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter amount to withdraw:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(amount);
            account.Print();
        }
        private static void DoPrint(Account account)
        {
            account.Print();
        }
        private static UserOption ReadUserOption()
        {
            int selection;
            do
            {
                Console.WriteLine("Please select an option (1-4):");
                selection = Convert.ToInt32(Console.ReadLine());
            }
            while (selection < 1 || selection > 4);

            return (UserOption)selection;
        }
    }
}