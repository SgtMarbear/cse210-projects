public class ChecklistGoal : Goal
{
    private int _completedTimes;
    private int _bonusTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int bonusTimes, int bonusPoints) : base(name, description, points)
    {
        _completedTimes = 0;
        _bonusTimes = bonusTimes;
        _bonusPoints = bonusPoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description}) -- Completed {_completedTimes}/{_bonusTimes} times");
    }

    public override bool IsCompleted()
    {
        return _completedTimes >= _bonusTimes;
    }

    public override int GetPoints()
    {
        if (IsCompleted())
            return _points + _bonusPoints;
        else
            return _points;
    }

    public override void RecordEvent()
    {
        _completedTimes++;
    }
}