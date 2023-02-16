public class Assignment 
{
    //Member variables or attributes
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //Getters
    public string GetStudentName()
    {
        return _studentName;
    }


    //Method
    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }
}