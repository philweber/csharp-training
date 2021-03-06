﻿using System;
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
            List<Flashcard> flashCards = new List<Flashcard>();

            // Open file
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (true)
                {
                    // Read a line
                    string line = reader.ReadLine();
                    if (line == null) break;

                    // Split into question and answer
                    string[] qAndA = line.Split('/');

                    // Create new Flashcard, set Q & A values
                    // and add to ArrayList

                    // Flashcard card;
                    // card.Question = qAndA[0];
                    // card.Answer = qAndA[1];

                    // flashCards.Add(card);

                    flashCards.Add(
                        new Flashcard
                        {
                            Question = qAndA[0],
                            Answer = qAndA[1]
                        }
                    );
                }
            }

            return flashCards;
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
