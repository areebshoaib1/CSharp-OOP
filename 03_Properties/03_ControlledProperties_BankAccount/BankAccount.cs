namespace Controlled_Properties
{
    internal class BankAccount
    {
        public string? AccountHolder { get; set; }

        // Readable from outside, only this class can change it
        public decimal Balance { get; private set; }

        public void Deposit()
        {
            Console.WriteLine("Enter Amount to Deposit");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal deposit))
            {
                Balance += deposit;
                Console.WriteLine("Balance Deposited Successfully");
            }
        }

        public void WithDraw()
        {
            Console.WriteLine("Enter Amount to Withdraw");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal withdraw))
            {
                if (withdraw > Balance)
                {
                    Console.WriteLine("Withdraw amount is larger than available Balance");
                }
                else
                {
                    Balance -= withdraw;
                    Console.WriteLine("Amount Withdrawn Successfully");
                }
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance Available: {Balance}");
        }
    }
}