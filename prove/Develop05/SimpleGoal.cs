public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points, bool status = false) : base (title, description,points)
    {
        _goalType = "SimpleGoal";
        SetCompleted(status);
    }

    public override string SaveGoal()
    {
        return $"{_goalType}:{GetTitle()},{GetDescription()},{GetPoints()},{GetCompleted()}";
    }
}