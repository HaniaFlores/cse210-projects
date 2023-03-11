public class EternalGoal : Goal
{
    public EternalGoal (string title, string description, int points) : base (title, description,points)
    {
        base._goalType = "EternalGoal";
    }

    public override void DisplayMessage()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public override string SaveGoal()
    {
        return $"{_goalType}:{GetTitle()},{GetDescription()},{GetPoints()}";
    }

}