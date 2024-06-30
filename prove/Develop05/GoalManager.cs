public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void CreateGoal(string name, string description, int points, string goalType, int bonusTimes = 0, int bonusPoints = 0)
    {
        Goal goal;
        if (goalType == "SimpleGoal")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (goalType == "EternalGoal")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (goalType == "ChecklistGoal")
        {
            goal = new ChecklistGoal(name, description, points, bonusTimes, bonusPoints);
        }
        else
        {
            throw new ArgumentException("Invalid goal type.");
        }

        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            Console.WriteLine($"Event recorded for goal: {_goals[goalIndex]._name}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals(string fileName)
    {
        // Implement saving goals to file
    }

    public void LoadGoals(string fileName)
    {
        // Implement loading goals from file
    }

    public int CalculateTotalPoints()
    {
        int totalPoints = 0;
        foreach (Goal goal in _goals)
        {
            totalPoints += goal.GetPoints();
        }
        return totalPoints;
    }
}
