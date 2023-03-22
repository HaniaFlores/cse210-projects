public abstract class Activity
{
    private DateTime _date;
    private int _duration;
    private string _activityType;


    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public void SetActivityType(string activityType) { _activityType = activityType; }
    public int GetDuration() { return _duration; }

    public abstract decimal GetDistance();
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_activityType} ({_duration} min) - Distance: {GetDistance().ToString("0.0")} miles, Speed: {GetSpeed().ToString("0.0")} mph, Pace: {GetPace().ToString("0.0")} min per mile";
    }

}