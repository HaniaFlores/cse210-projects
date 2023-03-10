public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points) : base (title, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($" [ ] {GetTitle()} ({GetDescription()})");
    }
}