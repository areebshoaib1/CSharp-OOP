namespace Controlled_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount B1 = new BankAccount();
            B1.AccountHolder = "M. Areeb Shoaib";

            B1.Deposit();
            B1.WithDraw();
            B1.ShowBalance();
        }
    }
}