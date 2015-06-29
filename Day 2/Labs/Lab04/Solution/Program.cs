using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab04
{
    static class Utils
    {
        // Returns the greater of two integer values
        public static int Greater(int a, int b)
        {
            return a > b ? a : b;
        }

        // Swaps the values of two integers
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test Greater method
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater value is {0}.", Utils.Greater(x, y));

            // Test Swap method
            Console.WriteLine("\nBefore swapping: x = {0}, y = {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine(" After swapping: x = {0}, y = {1}", x, y);
        }
    }
}
