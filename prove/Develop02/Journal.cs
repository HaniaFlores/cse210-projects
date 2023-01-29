//Journal Class template
using System.IO;
public class Journal
{

    public string _journalFile = "";

    public void CreateJournalFile(string file) {
        File.CreateText(file);
    }


    public void ClearJournal()
    {
        File.WriteAllText(UserFile(), "");
        Console.WriteLine("\nJournal Cleared");
    }

    public void SaveToFile()
    {
        string filename = UserFile();
        if (!File.Exists(filename))
        {
            CreateJournalFile(filename);
            Entry myEntry = new Entry();
            foreach (string i in myEntry._localJournal)
            {
                File.AppendAllText(filename, i);
            }
            Console.WriteLine("\nThe Journal has been modified!");
        }
        else {
            Entry myEntry = new Entry();
            foreach (string i in myEntry._localJournal)
            {
                File.AppendAllText(filename, i);
            }
            Console.WriteLine("\nThe Journal has been modified!");
        }
        
    }

    public void LoadFromFile()
    {
        _journalFile = UserFile();
        string journalText = File.ReadAllText(_journalFile);
        Console.WriteLine("\n=== Journal Contents ===");
        Console.WriteLine(journalText);
        Console.WriteLine("===========================");
    }

    public string UserFile()
    {
        Console.WriteLine("Insert the filename ex.(MyJournal.txt)");
        string filename = Console.ReadLine();
        if (filename.EndsWith(".txt"))
        {
            return filename;
        }
        else {
            Console.WriteLine("Please enter a valid text filename.");
            filename = Console.ReadLine();
            return filename;
        }
    }
}
