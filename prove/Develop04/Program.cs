using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "invalid";
        Menu thisMenu = new Menu();

        while (choice != "5") {
                thisMenu.DisplayMenu();
                choice = Console.ReadLine();
                thisMenu.SelectActivity(choice);
        }
    }
}