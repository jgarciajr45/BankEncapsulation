using System;
using System.Diagnostics;

namespace BankEncapsulation
{
    
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. Current balance is {_balance:C}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public double GetBalance()
        {
            return _balance;

        }

        
    }
}
    
