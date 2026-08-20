using System;


namespace OOP_Practice
{
    internal interface IPayable
    {
        public decimal ProcessPayment(decimal amount);
    }
    internal class Paypal : IPayable
    {
        private const decimal PayPal_tax = 0.05m;
        private decimal Tax_calculator;
        private decimal Sentable_amount;
        public decimal ProcessPayment(decimal amount)
        {
            Tax_calculator = amount * PayPal_tax;
            Sentable_amount = amount - Tax_calculator;
            Console.WriteLine($"Processed {amount} through Paypal\n{Sentable_amount} will receive by receiver");
            return Sentable_amount;
        }
    }
    internal class CreditCard : IPayable
    {
        private const decimal CreditCard_tax = 0.1m;
        private decimal Tax_calculator;
        private decimal Sentable_amount;
        public decimal ProcessPayment(decimal amount)
        {
            Tax_calculator = amount * CreditCard_tax;
            Sentable_amount = amount - Tax_calculator;
            Console.WriteLine($"\nProcessed {amount} through Credit Card\n{Sentable_amount} will receive by receiver");
            return Sentable_amount;
        }
    }

}