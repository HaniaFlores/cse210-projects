public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points, bool status = false) : base (title, description,points)
    {
        base._goalType = "SimpleGoal";
        base.SetCompleted(status);
    }

    public override void Display()
    {
        Console.WriteLine($" {base.MarkAsCompleted()} {GetTitle()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return $"{_goalType}:{base.GetTitle()},{base.GetDescription()},{_points},{base.GetCompleted()}";
    }
}