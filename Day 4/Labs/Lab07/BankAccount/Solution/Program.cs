using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab07
{
    enum AccountType
    {
        Checking,
        Savings,
        CD,
        Loan
    }

    class BankAccount
    {
        private static int nextAccountNumber = 1;

        public decimal Balance { get; private set; }

        public readonly int Number;
        public readonly AccountType? Type;

        public BankAccount(AccountType? type, decimal openingBalance)
        {
            this.Type = type;
            this.Balance = openingBalance;
            this.Number = nextAccountNumber++;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            AccountType? accountType;
            decimal balance = 0;

            do
            {
                Console.WriteLine("Create Account");
                Console.WriteLine("--------------");

                try
                {
                    Console.Write("Please enter an account type (Checking, Savings, CD, or Loan): ");
                    input = Console.ReadLine();
                    accountType = (AccountType)Enum.Parse(typeof(AccountType), input, true);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid account type. Must be Checking, Savings, CD, or Loan.");
                    accountType = null;
                }

                try
                {
                    Console.Write("Please enter an opening balance: ");
                    input = Console.ReadLine();
                    balance = decimal.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid account balance.");
                    balance = 0;
                }

                BankAccount account = new BankAccount(accountType, balance);

                Console.WriteLine("\nAccount Info");
                Console.WriteLine("-------------------");

                Console.WriteLine(" Number: {0}", account.Number);
                Console.WriteLine("   Type: {0}", account.Type);
                Console.WriteLine("Balance: {0:C}", account.Balance);
                Console.WriteLine();
            } while (true);
        }
    }
}