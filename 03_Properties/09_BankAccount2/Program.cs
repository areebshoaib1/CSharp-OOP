namespace BankAccount_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount2 B2 = new BankAccount2()
            {
                AccountHolder = "M. Areeb Shoaib"
            };

            Console.WriteLine("Initial Balance: " + B2.AccountBalance);

            B2.Deposit();
            B2.WithDraw();
            B2.DisplayAccount();
        }
    }
}