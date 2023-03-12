public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points, bool status = false) : base (title, description,points)
    {
        SetGoalType("SimpleGoal");
        SetCompleted(status);
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}:{GetTitle()},{GetDescription()},{GetPoints()},{GetCompleted()}";
    }
}