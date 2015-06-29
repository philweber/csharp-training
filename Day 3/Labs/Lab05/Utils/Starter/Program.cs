using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab05
{
    static class Utils
    {
        // Create new method named Reverse that 
        // accepts a string parameter and returns 
        // a string with the characters reversed

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

        }
    }
}
