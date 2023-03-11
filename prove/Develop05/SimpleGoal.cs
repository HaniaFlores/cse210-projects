public class SimpleGoal : Goal
{
    public SimpleGoal(List<string> goalInfo) : base (goalInfo)
    {
        base._goalType = "SimpleGoal";
    }

    public override void Display()
    {
        Console.WriteLine($" {base.MarkAsCompleted()} {GetTitle()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return $"{_goalType}:{base.GetTitle()},{base.GetDescription()},{_points}";
    }
}