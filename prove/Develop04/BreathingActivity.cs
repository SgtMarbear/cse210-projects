
public class BreathingActivity : Activity {

    private int _duration;
    
    public BreathingActivity(int duration)
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
        _duration = duration;
    }

    public void RunBreathingActivity()
    {
        Console.Clear();
        int remainingTime = DisplayStartingMessage();

        while (remainingTime > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);

            remainingTime -= 2; // Alternating breathe in and out
        }

        DisplayEndingMessage();
    }
}