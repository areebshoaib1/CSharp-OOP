namespace BankAccount_2
{
    internal class BankAccount2
    {
        public required string AccountHolder { get; set; }

        public decimal AccountBalance { get; private set; }

        public string AccountStatus => AccountBalance > 0 ? "Active" : "Empty";

        public void Deposit()
        {
            Console.WriteLine("Enter Amount to Deposit");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal deposit))
            {
                AccountBalance += deposit;
                Console.WriteLine("Balance Deposited Successfully");
            }
        }

        public void WithDraw()
        {
            Console.WriteLine("Enter Amount to Withdraw");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal withdraw))
            {
                if (withdraw > AccountBalance)
                {
                    Console.WriteLine("Withdraw amount is larger than available Balance");
                }
                else
                {
                    AccountBalance -= withdraw;
                    Console.WriteLine("Amount Withdrawn Successfully");
                }
            }
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"Account Details:\nAccount Holder Name: {AccountHolder}\nBalance Available: {AccountBalance}\nAccount Status: {AccountStatus}");
        }
    }
}