public class RunningActivity : Activity
{
    private decimal _distance;

    public RunningActivity(DateTime date, int duration, decimal distance) : base(date, duration)
    {
        _distance = distance;
        SetActivityType("Runnning");
    }

    public override decimal GetDistance() { return _distance; }

    public override decimal GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override decimal GetPace()
    {
        return GetDuration() / _distance;
    }
}