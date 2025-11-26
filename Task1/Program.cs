namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("12345", 5000);
            Console.WriteLine("Account Number: " + acc.AccountNumber);

            acc.Deposit(2000);
            acc.Withdraw(1000);

            Console.WriteLine("Remaining Balance: " + acc.Balance);

        }
    }
}
