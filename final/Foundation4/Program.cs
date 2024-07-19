using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2024, 7, 13), 30, 3.0));
        activities.Add(new Running(new DateTime(2024, 7, 18), 30, 4.8));
        activities.Add(new StationaryBicycle(new DateTime(2024, 7, 15), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2024, 7, 19), 60, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}