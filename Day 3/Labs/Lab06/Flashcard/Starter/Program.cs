using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace Flashcard
{
    // Create a struct named Flashcard, containing 
    // public string fields named Question and Answer.

    // Add a public method named Load that accepts a 
    // string called fileName and returns an ArrayList.
    // The method should open the specified file and read
    // one line at a time, splitting the line on the 
    // delimiter character (/). Create a new Flashcard
    // object, set its Question and Answer values, and
    // add it to an ArrayList. Finally, return the
    // ArrayList from the method.

    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "questions.txt";

            // Pass fileName to Flashcard.Load()
            // Assign result to ArrayList

            // For each item in ArrayList...
            // Display question and wait for keypress

            // Display answer and wait for keypress             
            // Repeat until done
        }
    }
}
