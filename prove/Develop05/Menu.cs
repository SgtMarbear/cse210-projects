
using System;

public class Menu
{
    private GoalManager _goalManager;

    public Menu()
    {
        _goalManager = new GoalManager();
    }

    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create new goal");
        Console.WriteLine("  2. List goals");
        Console.WriteLine("  3. Save goals");
        Console.WriteLine("  4. Load goals");
        Console.WriteLine("  5. Record event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void RunMenu()
    {
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            CreateNewGoal();
        }
        else if (choice == "2")
        {
            ListGoals();
        }
        else if (choice == "3")
        {
            SaveGoals();
        }
        else if (choice == "4")
        {
            LoadGoals();
        }
        else if (choice == "5")
        {
            RecordEvent();
        }
        else if (choice == "6")
        {
            QuitProgram();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    private void CreateNewGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Awesome! The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string optionTwo = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (optionTwo == "1")
        {
            _goalManager.CreateGoal(name, description, points, "SimpleGoal");
        }
        else if (optionTwo == "2")
        {
            _goalManager.CreateGoal(name, description, points, "EternalGoal");
        }
        else if (optionTwo == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int bonusTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goalManager.CreateGoal(name, description, points, "ChecklistGoal", bonusTimes, bonusPoints);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void ListGoals()
    {
        _goalManager.DisplayGoals();
    }

    private void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        _goalManager.SaveGoals(fileName);
    }

    private void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file to load? ");
        string fileName = Console.ReadLine();
        _goalManager.LoadGoals(fileName);
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        _goalManager.DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int goalCompNum;
        if (Int32.TryParse(Console.ReadLine(), out goalCompNum))
        {
            _goalManager.RecordEvent(goalCompNum - 1); // goalCompNum is displayed as 1-based index
        }
        else
        {
            Console.WriteLine("Invalid input for goal completion number.");
        }
    }

    private void QuitProgram()
    {
        Console.WriteLine("Exiting program.");
        Environment.Exit(0);
    }

    public static void Main(string[] args)
{
    Menu newMenu = new Menu();  // Create an instance of Menu

    while (true)
    {
        Console.WriteLine($"You have {newMenu._goalManager.CalculateTotalPoints()} points."); // Access _goalManager through newMenu instance
        newMenu.DisplayMenu();
        newMenu.RunMenu();
    }
}
}