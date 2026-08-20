
using System;
namespace OOP_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Define IPayable with method ProcessPayment(decimal amount). Implement it in CreditCard and PayPal classes with different logic.*/

            Paypal P1 = new Paypal();
            P1.ProcessPayment(10000);

            CreditCard C1 = new CreditCard();
            C1.ProcessPayment(10000);

            Console.ReadLine();



        }
    }
}
