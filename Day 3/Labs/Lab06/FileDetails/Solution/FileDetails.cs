using System;                // Console
using System.IO;             // File, StreamReader

namespace Lab06
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            string fileName = "";

            if (args.Length != 0)
            {
                fileName = args[0];
            }
            else
            {
                Console.Write("Please enter a file name: ");
                fileName = Console.ReadLine();
            }

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    char[] contents = new char[(int)reader.BaseStream.Length];
                    contents = reader.ReadToEnd().ToCharArray();

                    //for (int i = 0; i < size; i++)
                    //{
                    //    contents[i] = (char)reader.Read();
                    //}

                    Summarize(contents);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;

            foreach (char current in contents)
            {
                if (char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }

            Console.WriteLine("Characters: {0}", contents.Length);
            Console.WriteLine("Vowels    : {0}", vowels);
            Console.WriteLine("Consonants: {0}", consonants);
            Console.WriteLine("Lines     : {0}", lines);
        }
    }
}