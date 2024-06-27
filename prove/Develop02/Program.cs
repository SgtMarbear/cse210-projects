using System;

class Program
{
    static void Main(string[] args)
    {
        Entry journal = new Entry();
        FileInteraction newFileInteraction = new FileInteraction();

        while(true){
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Welcome to our journal program!");
            Console.WriteLine("(1) Write a new entry");
            Console.WriteLine("(2) Display the journal");
            Console.WriteLine("(3) Save the journal to a file");
            Console.WriteLine("(4) Load the journal from a file");
            // I added this additional option to give the user additional functionality with their journal entries.
            Console.WriteLine("(5) Sort journal entries alphabetically and then display");
            Console.WriteLine("(6) End program");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Which option would you like?");
            string user = Console.ReadLine();
            int input = int.Parse(user);

            if(input == 1) {
                journal.WriteEntry();

            }
            else if (input == 2) {
                journal.DisplayJournal();
            }
            else if (input == 3) {
                newFileInteraction.SaveTheFile();
            }
            else if (input == 4) {
                newFileInteraction.LoadJournalFromFile();
                
            }
            else if (input == 5) {
                // This is an extra option I added for the user to change the way their journal is displayed
                var sortedEntries = Entry.entries.OrderBy(entry => entry[0]).ToList();
                sortedEntries.ForEach(entry => {
                    Console.WriteLine($"Author: {entry[0]}");
                    Console.WriteLine($"Date: {entry[1]}");
                    Console.WriteLine($"Prompt: {entry[2]}");
                    Console.WriteLine($"Entry: {entry[3]}");
                    Console.WriteLine(new string('-', 60));
                    Console.WriteLine();
                });
            }
            else {
                Console.Write("Thanks for using this program! See you later!");
                return;
            }
        } 

    }
}