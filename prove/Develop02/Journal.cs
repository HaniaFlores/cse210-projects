//Journal Class template
using System.IO;
public class Journal
{
    public List<string> _entries = new List<string>();

    public string _journalFile = "";

    public void CreateJournalFile(string file) {
        File.CreateText(file);
    }


    public void ClearJournal()
    {
        File.WriteAllText(_journalFile, "");
        Console.WriteLine("\nJournal Cleared");
    }

    public void SaveToFile()
    {
        if (!File.Exists(_journalFile))
        {
            CreateJournalFile(_journalFile);
            foreach (string i in _entries)
            {
                File.WriteAllText(_journalFile, i);
            }
            Console.WriteLine("\nThe Journal has been modified!");
        }
        else
        {
            foreach (string i in _entries)
            {
                File.WriteAllText(_journalFile, i);
            }
            Console.WriteLine("\nThe Journal has been modified!");
        }
    }

    public void LoadFromFile()
    {
        string journalText = File.ReadAllText(_journalFile);
        Console.WriteLine("\n=== Journal Contents ===");
        Console.WriteLine(journalText);
        Console.WriteLine("===========================");
    }

    public void UserFile()
    {
        Console.WriteLine("Insert the filename ex.(MyJournal)");
        string filename = Console.ReadLine();
        _journalFile = filename + ".txt";

    }
}
