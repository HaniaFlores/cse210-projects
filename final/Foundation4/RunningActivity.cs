public class RunningActivity : Activity
{
    private decimal _distance;

    public RunningActivity(DateTime date, int duration, decimal distance) : base(date, duration)
    {
        _distance = distance;
        SetActivityType("Running");
    }

    public override decimal GetDistance() { return _distance; }

}