public class EternalGoal : Goal
{
    public EternalGoal (string title, string description, int points) : base (title, description,points)
    {
        SetGoalType("EternalGoal");
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}:{GetTitle()},{GetDescription()},{GetPoints()}";
    }

}