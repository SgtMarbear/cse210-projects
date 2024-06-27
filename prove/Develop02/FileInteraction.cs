
public class FileInteraction {

    private string _fileName;

    public void SaveTheFile() {
        Console.WriteLine("What is the file name?");
        _fileName = Console.ReadLine();

        List<string> linesToWrite = new List<string>();

        foreach (List<string> entry in Entry.entries) {
            linesToWrite.Add(entry[0]);  // Name
            linesToWrite.Add(entry[1]);  // Date
            linesToWrite.Add(entry[2]);  // Prompt
            linesToWrite.Add(entry[3]);  // Entry Text
            linesToWrite.Add("---");    // Separator
        }

        File.WriteAllLines(_fileName, linesToWrite);
        Console.WriteLine("Journal saved successfully to file.");
    }
    public void LoadJournalFromFile() {
        Console.WriteLine("What is the file name?");
        _fileName = Console.ReadLine();
        if (File.Exists(_fileName)) {
            Entry.entries.Clear();  // Clear existing entries

            string[] lines = File.ReadAllLines(_fileName);
            List<string> currentEntry = new List<string>();

            foreach (string line in lines) {
                if (line.Trim() == "---") {
                    if (currentEntry.Count == 4) {
                        Entry.entries.Add(new List<string>(currentEntry));
                        currentEntry.Clear();
                    }
                } else {
                    currentEntry.Add(line.Trim());
                }
            }

            if (currentEntry.Count == 4) {
                Entry.entries.Add(new List<string>(currentEntry));
            }

            Console.WriteLine("Journal loaded successfully from file.");
        } else {
            Console.WriteLine("File not found.");
        }
    }
}

