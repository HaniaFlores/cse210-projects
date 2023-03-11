using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int runningScore = 0;
        int response = 1;
        Data data = new Data();

        Console.Clear();
        while ((response > 0 && response < 6))
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
            response = int.Parse(Console.ReadLine());
            Console.Clear();

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
                        data.AddGoal(simple);
                    }
                    Console.WriteLine("\n   ---- A new goal has been added to the list! ----");
                    Thread.Sleep(1100);
                    Console.Clear();

                    break;
                case 2:
                    data.DisplayGoals();
                    Console.WriteLine();
                    break;
                case 3:
                    data.SaveToFile(runningScore);
                    break;
                case 4:
                    data.LoadFromFile();
                    Console.WriteLine("Data loaded. Now you can display your goals in the console.");
                    Console.WriteLine();
                    break;
                case 5:
                    data.DisplayGoals(false);
                    Console.Write("Which goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine());
                    Goal selectedGoal = data.GetList()[index - 1];
                    selectedGoal.DisplayMessage();
                    runningScore += selectedGoal.GetScore();
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Write("\nDid you save the data in a file? ");
                    string saved = Console.ReadLine().Trim();
                    if (saved == "No" || saved == "no")
                    {
                        data.SaveToFile(runningScore);
                    }
                    break;
            }
        }
        Console.WriteLine("Thanks for using the program. See you later!");
    }

}