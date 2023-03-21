public class Event {
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventTitle() { return _eventTitle; }
    public string GetDescription() { return _description; }
    public string GetDate() { return _date; }
    public string GetTime() { return _time; }
    public Address GetAddress() { return _address; }
    

    public void SetEventType(string eventType) { _eventType = eventType; }

    public string GetStandardDetails()
    {
        return $"Title: \"{_eventTitle}\"\nDescription: {_description}\nDate: {_date} at {_time}\nAddress: {_address.GetCompleteAddress()}";
    }

    public string GetShortDescription()
    {
        return $"{_eventType}\nTitle: \"{_eventTitle}\"\nDate: {_date}";
    }
}