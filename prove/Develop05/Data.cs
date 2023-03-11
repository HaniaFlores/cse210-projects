public class Data
{
    private List<Goal> _data = new List<Goal>();
    private string _filename;

    public void SaveToFile(int score)
    {
        SetFilename();
        if (!File.Exists(_filename))
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                outputFile.WriteLine(score);
                foreach (Goal goal in _data)
                {
                    outputFile.WriteLine(goal.SaveGoal());
                }
            }
            Console.WriteLine(" ---- The file has been created. ----");
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(_filename)) //without true the file will be overwriten if the user decides to save it before loading it.
            {
                outputFile.WriteLine(score);
                foreach (Goal goal in _data)
                {
                    outputFile.WriteLine(goal.SaveGoal());
                }
            }
            Console.WriteLine(" ---- The file has been updated. ----");
        }
    }

    public void LoadFromFile()
    {
        SetFilename();
        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines.Skip(1))
        {
            string goalType = line.Substring(0, line.IndexOf(":"));
            string[] parts = line.Split(",");
            string title = parts[0].Substring(parts[0].IndexOf(":") + 1);
            string desc = parts[1];
            int points = int.Parse(parts[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool status = bool.Parse(parts[3]);
                    SimpleGoal goal1 = new SimpleGoal(title, desc, points, status);
                    goal1.SetScore(int.Parse(lines[0]));
                    _data.Add(goal1);
                    break;
                case "EternalGoal":
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(parts[3]);
                    int times = int.Parse(parts[4]);
                    int _completed = int.Parse(parts[5]);
                    break;
            }
        }
    }

    public void DisplayGoals(bool mark = true)
    {
        int i = 1;
        Console.WriteLine("\nYour goals are:");
        while (i <= _data.Count())
        {
            foreach (Goal goal in _data)
            {
                Console.Write(i + ". ");
                goal.Display(mark);
                i++;
            }
        }
    }

    private void SetFilename()
    {
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();
    }  

    public void AddGoal(Goal goal) {
        _data.Add(goal);
    }

    public List<Goal> GetList()
    {
        return _data;
    }  
}