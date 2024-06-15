
public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration) {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int DisplayStartingMessage() {
        Console.WriteLine("Welcome to the " + _name + ".");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would uou like for your session?");
        _duration = Int32.Parse(Console.ReadLine());
        return _duration;

    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!!");
        PauseWithAnimation(3);
        Console.WriteLine();
        Console.WriteLine("You have completed another " + _duration + " seconds of the " + _name + ".");
        PauseWithAnimation(3);
    }

    public void PauseWithAnimation(int newTime) {
        int remainingTime = newTime;
        
        while (remainingTime > 0) {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            remainingTime -= 1;

        }
    }

}