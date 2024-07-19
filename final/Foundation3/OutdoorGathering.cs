public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public string WeatherForecast
    {
        get { return _weatherForecast; }
        set { _weatherForecast = value; }
    }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address location, string weatherForecast)
        : base(title, description, date, time, location){
        WeatherForecast = weatherForecast;
    }

    public override string GetEventType(){
        return "Outdoor Gathering";
    }

    public override string GetFullDetails(){
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}