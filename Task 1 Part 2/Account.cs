
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
        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount < _balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
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
