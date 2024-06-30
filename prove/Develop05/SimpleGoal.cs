
public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _completed = false;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override bool IsCompleted()
    {
        return _completed;
    }

    public override int GetPoints()
    {
        return _completed ? _points : 0;
    }

    public override void RecordEvent()
    {
        _completed = true;
    }
}