
public class FileInteraction {
    public void saveTheFile(List<string>entries) {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        System.IO.File.WriteAllLines(fileName, entries);
    }
}

