
public class Menu {
    private string _choice;

    public void DisplayMenu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create new goal");
        Console.WriteLine(" 2. List goals");
        Console.WriteLine(" 3. Save goals");
        Console.WriteLine(" 4. Load goals");
        Console.WriteLine(" 5. Record event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void RunMenu() {
        _choice = Console.ReadLine();
        if (_choice == "1") {

        } else if (_choice == "2") {

        } else if (_choice == "3") {

        } else if (_choice == "4") {

        } else if (_choice == "5") {

        } else if (_choice == "5") {

        } else if (_choice == "6") {

        } else {
            
        }
    }
}