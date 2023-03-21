public class LecturesEvent:Event
{
    private string _speaker;
    private int _capacity;
    public LecturesEvent(string eventTitle, string speaker, string description, string date, string time, Address address, int capacity) : base(eventTitle,description,date,time,address)
    {
        SetEventType("Lectures Event");
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Title: \"{GetEventTitle()}\"\nDescription: {GetDescription()}\nDate: {GetDate()} at {GetTime()}\nSpeaker: {_speaker}\nCapacity: {_capacity} people\nAddress: {GetAddress().GetCompleteAddress()}";
    }
}
