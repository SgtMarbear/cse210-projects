using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        // Display initial scripture
        scripture.ClearConsoleAndDisplayScripture();
        String input = "";

        while (input != "quit")
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            input = Console.ReadLine();
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
