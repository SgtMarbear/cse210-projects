public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed:F1} mph, Pace: {GetPace():F2} min per mile";
    }
}