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
    private HashSet<string> _usedQuestions = new HashSet<string>();

    public ReflectingActivity(string name, string description) : base (name, description)
    {
        //Where the program starts
        base.DisplayStartMessage();
        DisplayPrompt();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountdown(5);
    }

    public void RunActivity()
    {
        DisplayQuestion();
        base.ShowSpinner(10);
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
        Console.WriteLine($"\n --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();
    }

    public string GetRandomQuestion()
    {
        /*      EXCEEDING REQUIREMENTS

            Makes sure no random questions are selected until they have all
            been used at least once in that session.

            HashSet does not allow duplicates, that's why I have to clear it
            once its length is the same as the list of questions.

            do...while loop will continue choosing a random index if the
            question is already in the HashSet.

            Once a random question is selected, it will be added to the HashSet.
        
        */
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        string question;
        do
        {
            question = _questions[random.Next(_questions.Count)];
        } while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        return question;
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}