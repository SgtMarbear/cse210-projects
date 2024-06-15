
public class ListingActivity : Activity {
    private List<string> prompts;

    private int _duration;

    public ListingActivity(int duration)
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _duration = duration;
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    private string GetRandomPrompt() {
        Random rnd = new Random();
        int r = rnd.Next(prompts.Count);
        return prompts[r];
    }

    public void RunListingActivity() {
        Console.Clear();
        _duration = DisplayStartingMessage();
        
        Console.WriteLine("Get Ready . . .");
        PauseWithAnimation(5);
        Console.WriteLine("List as many responses you can to the following prompt:");

        Console.WriteLine("-----" + GetRandomPrompt() + "-----");
        Console.WriteLine("You may begin in: ");

        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Console.Write("\b \b");


        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("You listed " + itemCount + " items.");

        DisplayEndingMessage();
    
    }
}