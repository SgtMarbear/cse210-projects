public abstract class Goal
{
    public string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void DisplayGoal();
    public abstract bool IsCompleted();
    public abstract int GetPoints();
    public abstract void RecordEvent();
}
