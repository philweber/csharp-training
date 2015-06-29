using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 1. Change BankAccount from a struct to a class.
//    What changes does this require in the test program?

// 2. People should not be able to change their account 
//    balances at will. Change balance to a private field 
//    and add public Deposit, Withdraw, and GetBalance
//    methods. Change test program as needed.

// 3. People don't generally choose their own account
//    numbers. Make the Number field readonly and add a 
//    static field called nextAccountNumber; initialize 
//    this field to 1. Add a public BankAccount constructor 
//    that sets the Number field to the next account number 
//    and increments nextAccountNumber.
//
//    Add a loop to the test program so that it creates
//    multiple accounts.

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
        public decimal Balance;
        public int Number;
        public AccountType? Type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(); ;
            string input;

            Console.WriteLine("Create Account");
            Console.WriteLine("--------------");
            
            Console.Write("Please enter an account number: ");
            account.Number = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("Please enter an account type (Checking, Savings, CD, or Loan): ");
                input = Console.ReadLine();
                account.Type = (AccountType)Enum.Parse(typeof(AccountType), input, true);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid account type. Must be Checking, Savings, CD, or Loan.");
                account.Type = null;
            }

            try
            {
                Console.Write("Please enter an opening balance: ");
                input = Console.ReadLine();
                account.Balance = decimal.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid account balance.");
            }

            Console.WriteLine("\nAccount Info");
            Console.WriteLine("-------------------");

            Console.WriteLine(" Number: {0}", account.Number);
            Console.WriteLine("   Type: {0}", account.Type);
            Console.WriteLine("Balance: {0:C}", account.Balance);
        }
    }
}
