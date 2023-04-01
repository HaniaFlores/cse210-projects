public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine("------------------------------- NEW VIDEO -------------------------------");
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine(ConvertSecondsToMinutes(_length));

        /* For each loop to display the comments */
        Console.WriteLine($"\nComments ({_comments.Count()}):");
        foreach(Comment i in _comments)
        {
            i.Display();
        }
    }

    public string ConvertSecondsToMinutes(int seconds)
    {
        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;

        return $"Duration {minutes}:{remainingSeconds}";
    }
}