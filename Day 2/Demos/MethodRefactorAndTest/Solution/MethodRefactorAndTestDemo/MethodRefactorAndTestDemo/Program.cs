using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodRefactorAndTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 48;
            int max = 50;
            int numRequired = 100;

            int[] randomNumbers = GenerateRandomNumbers(min, max, numRequired);

            Array.Sort(randomNumbers);
        }

        private static int[] GenerateRandomNumbers(int min, int max, int numRequired)
        {
            int[] randomNumbers = new int[numRequired];

            Random numberGenerator = new Random();

            for (int count = 0; count < numRequired; count++)
            {
                randomNumbers[count] = numberGenerator.Next(min, max);
            }
            return randomNumbers;
        }
    }
}
