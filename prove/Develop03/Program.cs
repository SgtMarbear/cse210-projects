using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        Scripture scripture = new Scripture(reference);

        // Display initial scripture
        scripture.ClearConsoleAndDisplayScripture();

        while (true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.AreAllWordsHidden())
            {
                // Hide only three words at a time
                scripture.HideRandomWord(3);
                scripture.ClearConsoleAndDisplayScripture();
            }
            else
            {
                Console.WriteLine("All words in the scripture are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}
