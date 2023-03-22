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
        return _laps * 50m / 1000m * 0.62m;
    }

    public override decimal GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60 ;
    }

    public override decimal GetPace()
    {
        return 60 / GetSpeed();
    }
}