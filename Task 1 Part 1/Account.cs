
namespace EraaSoft
{
    internal class Account
    {
        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }
        private string _name;
        private decimal _balance;
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Welcome {_name} Your balance is {_balance}");
        }
    }
}
