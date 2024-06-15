
public class GratitudeActivity : Activity {
    private int _duration;
    private string _thanks;

    public GratitudeActivity(int duration)
            : base("Gratitude Activity", "This activity will help you reflect on things in your life that you are grateful for.", duration)
        {
            _duration = duration;
        }
    
    public void RunGratitudeActivity() {
        Console.Clear();
        _duration = DisplayStartingMessage();
        int timeRemaining = _duration;

        while (timeRemaining > 0) {
            Console.WriteLine();
            Console.WriteLine("Please think of something that you are grateful for. Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Awesome! What did you pick?");
            _thanks = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now close your eyes and visulaize " + _thanks);
            Console.WriteLine("Imagine how it looks, sounds, smells, and how it makes you feel.");
            PauseWithAnimation(5);
            Console.WriteLine();
            Console.WriteLine("Take a moment to reflect on these feelings.");
            PauseWithAnimation(3);
            Console.WriteLine();
            timeRemaining = timeRemaining - 8;
        }
        DisplayEndingMessage();
    }

}



