using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> entries;
        entries = new List<string>();

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
                // I added some extra code to save the entry author's name to the entry.
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                PromptGenerator p = new PromptGenerator();
                string currentPrompt = p.Prompt();
                Console.WriteLine(currentPrompt);

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                string entry = Console.ReadLine();

                entries.Add(dateText + " " + name + " " + currentPrompt + '\n' + entry);

            }
            else if (input == 2) {
                entries.ForEach(entry => Console.WriteLine(entry));
            }
            else if (input == 3) {
                Entry newEntry = new Entry();
                newEntry.saveTheFile(entries);
            }
            else if (input == 4) {
                Console.WriteLine("Enter a file name: ");
                string fileName = Console.ReadLine();
                loadJournalFromFile(fileName, entries);
                Console.WriteLine("Journal loaded from file.");
                
            }
            else if (input == 5) {
                // This is an extra option I added for the user to change the way their journal is displayed
                entries.Sort();
                entries.ForEach(entry => Console.WriteLine(entry));
            }
            else {
                Console.Write("Thanks for using this program! See you later!");
                return;
            }
        } 

    }
    static void loadJournalFromFile(string fileName, List<string> entries)
    {
        if (File.Exists(fileName))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(fileName);
            entries.AddRange(lines);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}