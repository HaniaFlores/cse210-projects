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
        _prompt = generator.GeneratePrompt();
        Console.Write("Date: ");
        _date = Console.ReadLine();
        Console.WriteLine(_prompt);
        _userInput = Console.ReadLine();
        string newEntry = $"Date:{ _date}\nPrompt:{ _prompt}\nAnswer:{ _userInput}\n";
        _localJournal.Add(newEntry);
    }

    public void Display()
    {
        Console.WriteLine("\n=== Journal Contents ===");
        foreach (string entry in _localJournal) {
            Console.WriteLine(entry);
        }
        Console.WriteLine("===========================");
    }
}