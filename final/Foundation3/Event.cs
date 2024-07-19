public abstract class Event {
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _location;

    public string Title 
    { 
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public TimeSpan Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address Location
    {
        get { return _location; }
        set { _location = value; }
    }
    public Event(string title, string description, DateTime date, TimeSpan time, Address location)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Location = location;
    }
    public abstract string GetEventType();

    public virtual string GetStandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString(@"hh\:mm")}\nLocation: {Location}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"{GetEventType()} - {Title}\nDate: {Date.ToShortDateString()}";
    }
}