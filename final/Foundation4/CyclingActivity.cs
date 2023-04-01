public class CyclingActivity : Activity
{
    private decimal _speed;

    public CyclingActivity(DateTime date, int duration, decimal speed) : base(date,duration)
    {
        _speed = speed;
        SetActivityType("Cycling");
    }

    public override decimal GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }

    public override decimal GetSpeed() { return _speed; }
}