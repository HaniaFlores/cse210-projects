public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date,duration)
    {
        _laps = laps;
        SetActivityType("Swimming");
    }

    public override decimal GetDistance()
    {
        /* Added m to ensure accurate results */
        return _laps * 50m / 1000m * 0.62m;
    }
}