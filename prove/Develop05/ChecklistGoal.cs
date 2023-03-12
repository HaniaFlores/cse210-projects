public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal (string title, string description, int points, int bonus, int target, int count = 0, bool status = false) : base (title, description, points)
    {
        _goalType = "ChecklistGoal";
        _target = target;
        _bonus = bonus;
        _count = count;
        if (_count == _target)
        {
            status = true;
        }
        SetCompleted(status);

    }

    public override string SaveGoal()
    {
        return $"{_goalType}:{GetTitle()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_count}";
    }

    public override void Display(bool mark)
    {
        if (mark == true)
        {
            Console.WriteLine($"{MarkAsCompleted()} {GetTitle()} ({GetDescription()}) -- Currently completed {_count}/{_target}");
        }
        else
        {
            Console.WriteLine(GetTitle());
        }
    }

    public override void DisplayMessage()
    {
        _count++;
        AddBonus();
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        IsCompleted();
    }

    public void IsCompleted()
    {
        if (_count == _target)
        {
            SetCompleted(true);
        }
        else {
            SetCompleted(false);
        }
    }

    public void AddBonus()
    {
        if (_count == _target && GetCompleted() == false)
        {
            int points = GetPoints() + _bonus;
            SetPoints(points);
        }
    }
}