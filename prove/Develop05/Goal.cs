public abstract class Goal
{
    private string _goalType;
    private string _title;
    private string _description;
    private int _points;
    private bool _completed;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public string GetTitle() { return _title.Trim(); }

    public string GetDescription() { return _description.Trim(); }

    public void SetCompleted(bool status) { _completed = status; }
    public bool GetCompleted() { return _completed; }

    public void SetGoalType(string goalType) { _goalType = goalType; }
    public string GetGoalType() { return _goalType; }

    public virtual void Display(bool mark) {
        if (mark == true)
        {
            Console.WriteLine($"{MarkAsCompleted()} {_title} ({_description})");
        }
        else
        {
            Console.WriteLine(_title);
        }
    }


    public abstract string SaveGoal();
/* 
    public string RecordEvent()
    {
        return $"{_title} {_description}";
    } */

    public int GetPoints() { return _points; }

    public virtual void DisplayMessage()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _completed = true;
    }

    public string MarkAsCompleted()
    {
        if(_completed == true)
        {
            return "[X]";
        }
        else {
            return "[ ]";
        }
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

}