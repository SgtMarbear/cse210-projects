

public class Entry {

    public static List<List<string>> entries = new List<List<string>>();


    public void WriteEntry() {
        // I added some extra code to save the entry author's name to the entry.
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        PromptGenerator p = new PromptGenerator();
        string currentPrompt = p.Prompt();
        Console.WriteLine(currentPrompt);

        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        string entry = Console.ReadLine();

        List<string> newRow = new List<string> { name, dateText, currentPrompt, entry };
        entries.Add(newRow);
        Console.WriteLine("Thank you! Your journal entry has been saved in the system!");
    }
    public void DisplayJournal() {
        Console.WriteLine("Journal Entries:");
        Console.WriteLine(new string('-', 40));  // Separator

        for (int i = 0; i < entries.Count; i++) {
            List<string> entry = entries[i];
            Console.WriteLine($"Entry {i + 1}:");
            Console.WriteLine($"Name: {entry[0]}");
            Console.WriteLine($"Date: {entry[1]}");
            Console.WriteLine($"Prompt: {entry[2]}");
            Console.WriteLine($"Entry: {entry[3]}");
            Console.WriteLine(new string('-', 40));  // Separator
        }
    }

}


