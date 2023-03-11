public abstract class Goal
{
    protected string _goalType;
    private string _title;
    private string _description;
    protected int _points;
    private bool _completed;
    /* private int _score = 0; */

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public string GetTitle() { return _title.Trim(); }

    public string GetDescription() { return _description.Trim(); }

    /* public int GetScore() { return _score; }
    public void SetScore(int score) {_score = score;} */

    public void SetCompleted(bool status) { _completed = status; }
    public bool GetCompleted() { return _completed; }

    public void SetGoalType(string goalType) { _goalType = goalType; }

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


    public virtual string SaveGoal()
    {
        return $"{_goalType}:{_title},{_description},{_points}";
    }

    public string RecordEvent()
    {
        return $"{_title} {_description}";
    }


    /* public void AddPoints() { _score += _points; } */
    public int GetPoints() { return _points; }

    // public int GetScore() {
    //     return _score;
    // }
    // public abstract void AddGoal();
    // public abstract void RecordEvent();
    // public abstract bool IsComplete(); //will return the status.
    public virtual void DisplayMessage()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        /* AddPoints(); */
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

}