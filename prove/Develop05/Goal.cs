public abstract class Goal
{
    private string _goalType;
    private string _title;
    private string _description;
    private int _points;
    private bool _completed;
    private int _score = 0;

    public Goal(List<string> goalInfo)
    {
        _title = goalInfo[0];
        _description = goalInfo[1];
        _points = int.Parse(goalInfo[2]);
        _completed = false;
    }

    public string GetTitle() { return _title; }

    public string GetDescription() { return _description; }

    public int GetScore() { return _score; }

    public void SetCompleted(bool status) { _completed = status; }

    public void SetGoalType(string goalType) { _goalType = goalType; }

    public abstract void Display();

    public void AddPoints() { _score += _points; }

    // public int GetScore() {
    //     return _score;
    // }
    // public abstract void AddGoal();
    // public abstract void RecordEvent();
    // public abstract bool IsComplete(); //will return the status.
    public void DisplayMessage()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"You now have {_score} points.");
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