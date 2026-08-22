namespace _02_BankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount B1 = new BankAccount();

            B1.CheckBalance();
            B1.Deposit(500);
            B1.Withdraw(250);
            B1.CheckBalance();
        }
    }
}
