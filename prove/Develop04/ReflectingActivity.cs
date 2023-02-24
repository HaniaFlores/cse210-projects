public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base (name, description)
    {
        //Where the program starts
        base.DisplayStartMessage();
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.ShowSpinner();
        DisplayPrompt();
    }

    public void RunActivity()
    {
        DisplayQuestion();
        base.ShowSpinner(15);
    }

    Random random = new Random();

    public string GetRandomPrompt()
    {
        int promptListIndex = random.Next(_prompts.Count);
        return _prompts[promptListIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();
    }

    public string GetRandomQuestion()
    {
        int questionListIndex = random.Next(_questions.Count);
        return _questions[questionListIndex];
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }


}