public class SimpleGoal : Goal
{
    public SimpleGoal(List<string> goalInfo) : base (goalInfo)
    {
        base.SetGoalType("SimpleGoal");
    }

    public override void Display()
    {
        Console.WriteLine($" {base.MarkAsCompleted()} {GetTitle()} ({GetDescription()})");
    }
}