public abstract class Goal
{
    // private string _goalType;
    private string _title;
    private string _description;
    private int _points;
    private bool _completed;
    private int _score = 0;

    public Goal(string title, string description, int points)
    {
        // _goalType = goalType;
        _title = title;
        _description = description;
        _points = points;
    }

    public string GetTitle() {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract void Display();

    // public int GetScore() {
    //     return _score;
    // }
    // public abstract void AddGoal();
    // public abstract void RecordEvent();
    // public abstract bool IsComplete(); //will return the status.
    // public abstract void AddPoints();
    // public void DisplayMessage()
    // {
    //     Console.WriteLine("Good Job");
    // }

}