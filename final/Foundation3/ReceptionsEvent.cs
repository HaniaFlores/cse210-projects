public class ReceptionsEvent:Event
{
    private string _email;

    public ReceptionsEvent(string eventTitle, string description, string date, string time, Address address, string email) : base(eventTitle, description, date, time, address)
    {
        SetEventType("Receptions Event");
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nPlease confirm your assistance at {_email}";
    }
}