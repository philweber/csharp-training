using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    static class Utils
    {
        // Reverses the characters in a string
        public static string Reverse(string a)
        {
            return new string(a.Reverse().ToArray());

            //char[] chars = a.ToCharArray();
            //Array.Reverse(chars);
            //return new string(chars);

            //StringBuilder result = new StringBuilder();

            //// Read one character at a time from input 
            //// string and append to StringBuilder
            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    result.Append(a[i]);
            //}

            //// Convert StringBuilder to string and return
            //return result.ToString();
        }

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
            // Test Reverse method
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("The reverse of '{0}' is '{1}'.", 
                input, Utils.Reverse(input));
        }
    }
}
