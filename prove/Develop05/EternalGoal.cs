public class EternalGoal : Goal
{
    public EternalGoal (string title, string description, int points) : base (title, description,points)
    {
        SetGoalType("EternalGoal");
    }

    public override void DisplayMessage()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}:{GetTitle()},{GetDescription()},{GetPoints()}";
    }

}