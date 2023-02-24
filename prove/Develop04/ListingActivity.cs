public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _responses = 0;

    public ListingActivity (string name, string description) : base (name, description)
    {
        base.DisplayStartMessage();
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.ShowSpinner();
        DisplayPrompt();
    }

    public int GetResponses()
    {
        return _responses;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptListIndex = random.Next(_prompts.Count);
        return _prompts[promptListIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        base.ShowCountdown(5);
        Console.WriteLine();
    }

    public void RunActivity()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        _responses++;
    }
}