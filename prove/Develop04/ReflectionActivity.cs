
public class ReflectionActivity : Activity {

    private int _duration;
    private List<String> prompts;
    private List<String> questions;
    
    public ReflectionActivity(int duration)
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _duration = duration;

        prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public string GetRandomPrompt() {
        Random rnd = new Random();
        int r = rnd.Next(prompts.Count);
        return prompts[r];
    }

    public string GetRandomQuestion() {
        Random rand = new Random();
        int ra = rand.Next(questions.Count);
        return questions[ra];
    }

    public void RunReflectionActivity() {
        Console.Clear();
        _duration = DisplayStartingMessage();
        Console.WriteLine("Get Ready . . .");
        PauseWithAnimation(5);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("-----" + GetRandomPrompt() + "-----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
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
        Console.Clear();

        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.WriteLine(GetRandomQuestion());
            PauseWithAnimation(7);

            remainingTime -= 7;
        }

        DisplayEndingMessage();
    }


}



