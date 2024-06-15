
using System.Diagnostics;

public class Menu {
    private List<Activity> _activities;

    public void DisplayMenu() {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Start gratitude activity");
        Console.WriteLine("    5. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
    }

    public void SelectActivity(string choice) {
        Console.Clear();
        if (choice == "1") {
            BreathingActivity breathingActivity = new BreathingActivity(0);
            breathingActivity.RunBreathingActivity();
        }
        else if (choice == "2") {
            ReflectionActivity reflectionActivity = new ReflectionActivity(0);
            reflectionActivity.RunReflectionActivity();
        }
        else if (choice == "3") {
            ListingActivity listingActivity = new ListingActivity(0);
            listingActivity.RunListingActivity();
        }
        else if (choice == "4") {
            GratitudeActivity gratitudeActivity = new GratitudeActivity(0);
            gratitudeActivity.RunGratitudeActivity();
        }
        else if (choice == "5") {
            Console.WriteLine("Thank you for using this program!");
        }
        else {
            Console.WriteLine("Sorry, the option you entered is invalid. Please try again.");
        }
    }


}