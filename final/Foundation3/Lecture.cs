public class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public string Speaker { 
        get { return _speaker; }
        set { _speaker = value; }
    }

    public int Capacity {
        get { return _capacity; }
        set { _capacity = value; }
    }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address location, string speaker, int capacity)
        : base(title, description, date, time, location) {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetEventType() {
        return "Lecture";
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}