using System;
using System.Collections.Generic;
using System.Text;

namespace _02_BankAccountSystem
{
    internal class BankAccount
    {

        private decimal _balance = 0m;

        internal void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount}  Successfully");
        }
        internal void Withdraw(decimal amount)
        {
            if (amount <= _balance)
            {

                _balance -= amount;
                Console.WriteLine($" {amount}  Withdrawn Successfully");
            }
            else

                Console.WriteLine("Withdraw Balance is higher then Balance avaialable in your Account");
        }
        
        internal void CheckBalance()
        {

            Console.WriteLine($"Balance available: {_balance}");
        }



    }
}
