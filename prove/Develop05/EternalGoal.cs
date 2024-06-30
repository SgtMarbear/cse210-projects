
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // Eternal goals do not have a completion state
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override bool IsCompleted()
    {
        return false; // Eternal goals are never completed
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override void RecordEvent()
    {
        // No action needed for recording events for eternal goals
    }
}