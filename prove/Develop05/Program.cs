using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        List<Goal> goals = new List<Goal>();
        int runningScore = 0;
        int response = 1;

        while (response > 0 && response < 6)
        {

            //Menu
            Console.WriteLine($"You have {runningScore} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Convert.ToInt32(Console.ReadLine());

            //Swith Case
            switch (response)
            {
                case 1:
                    Console.WriteLine("\nThe types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("What type of goal would you like to create? ");
                    string selection = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string desc = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    //If statements
                    if (selection == "1" || selection == "Simple Goal")
                    {
                        SimpleGoal simple = new SimpleGoal(title,desc,points);
                        goals.Add(simple);
                    }
                    break;
                case 2:
                    Console.WriteLine("Your goals are:");
                    ListGoals(goals);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    SaveToFile(goals, filename, runningScore);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    goals = LoadFromFile(filename);
                    Console.WriteLine("Data loaded. Now you can display your goals in the console.");
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }

/*     static List<string> NewGoal()
    {
        List<string> goalInfo = new List<string>();
        Console.Write("What is the name of your goal? ");
        goalInfo.Add(Console.ReadLine());

        Console.Write("What is a short description of it? ");
        goalInfo.Add(Console.ReadLine());

        Console.Write("What is the amount of points associated with this goal? ");
        goalInfo.Add(Console.ReadLine());

        return goalInfo;
    } */

    static void SaveToFile(List<Goal> goals, string filename, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(score);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    static List<Goal> LoadFromFile(string filename)
    {
        string [] lines = System.IO.File.ReadAllLines(filename);
        List<Goal> loadedGoals = new List<Goal>();
        foreach (string line in lines.Skip(1))
        {
            string goalType = line.Substring(0,line.IndexOf(":"));
            string[] parts = line.Split(",");
            string title = parts[0].Substring(parts[0].IndexOf(":") + 1);
            string desc = parts[1];
            int points = int.Parse(parts[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool status = bool.Parse(parts[3]);
                    SimpleGoal goal1 = new SimpleGoal(title,desc,points,status);
                    loadedGoals.Add(goal1);
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
        return loadedGoals;
    }

    static void ListGoals(List<Goal> goals)
    {
        int i = 1;
        while (i <= goals.Count())
        {
            foreach (Goal goal in goals)
            {
                Console.Write(i + ".");
                goal.Display();
                i++;
            }
        }
    }
}