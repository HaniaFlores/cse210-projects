public class OutdoorEvent:Event
{
    private string _weatherForecast;

    public OutdoorEvent(string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base(eventTitle, description, date, time, address)
    {
        SetEventType("Outdoor Event");
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"Title: \"{GetEventTitle()}\"\nDescription: {GetDescription()}\nDate: {GetDate()} at {GetTime()}\nAddress: {GetAddress().GetCompleteAddress()}\nWeather Forecast: {_weatherForecast}";
    }
}