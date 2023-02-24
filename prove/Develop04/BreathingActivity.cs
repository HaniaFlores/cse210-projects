public class BreathingActivity : Activity
{
    private string _breathIn = "\nBreath In...";
    private string _breathOut = "\nBreath Out...";

    public BreathingActivity(string name, string description) : base (name, description)
    {
        base.DisplayStartMessage();
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.ShowSpinner();
        Thread.Sleep(1000);

    }

    public void RunActivity()
    {
        Console.Write(_breathIn);
        base.ShowCountdown(5);

        Console.Write(_breathOut);
        base.ShowCountdown(5);
        Console.WriteLine();
    }
}