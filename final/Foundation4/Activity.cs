using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_minutes} min)";
    }
    protected DateTime GetDate()
    {
        return _date;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }
}
