public class Reception : Event
{
    private string _rsvpContactEmail;

    public string RsvpContactEmail
    {
        get { return _rsvpContactEmail; }
        set { _rsvpContactEmail = value; }
    }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address location, string rsvpContactEmail)
        : base(title, description, date, time, location){
        RsvpContactEmail = rsvpContactEmail;
    }

    public override string GetEventType() {
        return "Reception";
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Contact Email: {RsvpContactEmail}";
    }
}