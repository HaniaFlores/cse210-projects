//Entry Class template
public class Entry
{
    PromptGenerator generator = new PromptGenerator();
    Journal myJournal = new Journal();

    public string _date = "";

    public string _prompt = "";
    public string _userInput = "";

    public List<string> _localJournal = new List<string>();


    public void AddEntry()
    {
        Console.Write("\nDate: ");
        _date = Console.ReadLine();
        _prompt = generator.GeneratePrompt();
        Console.WriteLine(_prompt);
        Console.WriteLine("Write your answer (Type EXIT and press enter to stop)");

        bool shouldContinue = true;
        while (shouldContinue)
        {
            string line = Console.ReadLine();
            if (line.ToLower().Trim() == "exit")
            {
                shouldContinue = false;
            }
            else {
                _userInput += line + "\n";
            }
        }
        string newEntry = $"Date: { _date}\nPrompt: { _prompt}\nAnswer: { _userInput}\n";
        _localJournal.Add(newEntry);
    }

    public void Display()
    {
        Console.WriteLine("\n=== Journal Contents ===\n");
        foreach (string entry in _localJournal) {
            Console.WriteLine(entry);
        }
        Console.WriteLine("===========================");
 
    }
}