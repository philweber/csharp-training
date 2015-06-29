using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02
{
    enum AccountType
    {
        Checking,
        Savings,
        CD,
        Loan
    }

    struct BankAccount
    {
        public string Number;
        public AccountType Type;
        public decimal Balance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;
            string input;

            Console.WriteLine("Create Account");
            Console.WriteLine("--------------");
            
            Console.Write("Please enter an account number: ");
            account.Number = Console.ReadLine();

            Console.Write("Please enter an account type (Checking, Savings, CD, or Loan): ");
            input = Console.ReadLine();
            account.Type = (AccountType)Enum.Parse(typeof(AccountType), input, true);

            Console.Write("Please enter an opening balance: ");
            input = Console.ReadLine();
            account.Balance = decimal.Parse(input);

            Console.WriteLine("\nAccount Info");
            Console.WriteLine("-------------------");

            Console.WriteLine(" Number: {0}", account.Number);
            Console.WriteLine("   Type: {0}", account.Type);
            Console.WriteLine("Balance: {0:C}", account.Balance);
        }
    }
}
