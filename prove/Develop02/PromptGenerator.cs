public class PromptGenerator {

    List<String> _prompts;
    private int _r;
    public PromptGenerator(){
        _prompts = new List<String>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("Detail a small act of kindness you either witnessed or participated in today. How did it make you or others feel?");
        _prompts.Add("Write about a conversation you had today that left a lasting impression on you.");
        _prompts.Add("Reflect on a challenge you faced today, big or small. How did you navigate it, and what did you learn from the experience?");
        _prompts.Add("Think about a goal or aspiration you have for the future. What small step did you take today to move closer to achieving it?");
        _prompts.Add("Describe a moment today when you felt grateful for someone's presence in your life. What specifically about their presence brought you joy or comfort?");
    }

    public String Prompt(){
        Random rnd = new Random();
        _r = rnd.Next(_prompts.Count);
        return _prompts[_r];
    }
}

