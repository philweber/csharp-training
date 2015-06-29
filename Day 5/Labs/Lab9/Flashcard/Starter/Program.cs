using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Flashcard
{
    struct Flashcard
    {
        public string Question;
        public string Answer;

        public static List<Flashcard> Load(string fileName)
        {
             return (from currentLine in File.ReadAllLines(fileName)
                     let qAndA = currentLine.Split('/')
                     where qAndA.Length >= 2
                     select new Flashcard()
                     {
                         Question = qAndA[0],
                         Answer = qAndA[1]
                     }).ToList<Flashcard>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "questions.txt";

            // Pass fileName to Flashcard.Load()
            // Assign result to ArrayList
            List<Flashcard> flashCards = Flashcard.Load(fileName);

            // For each item in list...
            foreach (Flashcard flashCard in flashCards)
            {
                // Display question and wait for keypress
                Console.Write(flashCard.Question);
                Console.ReadLine();

                // Display answer                
                Console.WriteLine(flashCard.Answer);
                Console.ReadLine();
            }   // Repeat
        }
    }
}
