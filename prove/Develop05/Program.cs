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

                    //If statements
                    if (selection == "1" || selection == "Simple Goal")
                    {
                        List<string> info = NewGoal();
                        SimpleGoal simple = new SimpleGoal(info[0], info[1], Convert.ToInt32(info[2]));
                        goals.Add(simple);
                    }
                    break;
                case 2:
                    Console.WriteLine("Your goals are:");
                    foreach(Goal goal in goals)
                    {
                        goal.Display();
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }

    static List<string> NewGoal()
    {
        List<string> goalInfo = new List<string>();
        Console.Write("What is the name of your goal? ");
        goalInfo.Add(Console.ReadLine());

        Console.Write("What is a short description of it? ");
        goalInfo.Add(Console.ReadLine());

        Console.Write("What is the amount of points associated with this goal? ");
        goalInfo.Add(Console.ReadLine());

        return goalInfo;
    }
}