namespace HomeWork2.Task2
{
    public class BankAccount
    {
        private int balance = 0;

        public void Deposit(double amount)
        {
            int amountInt = Convert.ToInt32(amount);

            if (amountInt <= 0)
            {
                Console.WriteLine("The amount should be larger than 0");
                return;
            }

            balance += amountInt;
        }

        public void Withdraw(double amount)
        {
            int amountInt = Convert.ToInt32(amount);

            if (amountInt <= 0)
            {
                Console.WriteLine("The amount should be larger than 0");
                return;
            }

            if (balance < amountInt)
            {
                Console.WriteLine("There is not enough balance.");
                return;
            }

            balance -= amountInt;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance ==> ${balance}");
        }
    }
}