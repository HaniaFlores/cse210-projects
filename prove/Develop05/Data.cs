public class Data
{
    private List<Goal> _data = new List<Goal>();
    private string _filename;
    private int _score;

    public int GetScore()
    {
        return _score;
    }

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
            using (StreamWriter outputFile = new StreamWriter(_filename))
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
        /* EXCEEDING REQUIREMENTS:
        If the user has created and accomplished some goals before loading a file,
        the console will show the goals we got from the file and the previously created ones.
        The score will also be updated. */

        SetFilename();
        List<string> lines = new List<string>();
        using (StreamReader reader = new StreamReader(_filename))
        {
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        foreach (string line in lines)
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
                    SimpleGoal simple = new SimpleGoal(title, desc, points, status);
                    _data.Add(simple);
                    break;
                case "EternalGoal":
                    EternalGoal eternal = new EternalGoal(title, desc, points);
                    _data.Add(eternal);
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int count = int.Parse(parts[5]);
                    ChecklistGoal checklist = new ChecklistGoal(title,desc,points,bonus,target,count);
                    _data.Add(checklist);
                    break;
            }
        }
    }

    public void DisplayGoals(bool mark = true)
    {
        int i = 1;
        Console.WriteLine("Your goals are:");
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