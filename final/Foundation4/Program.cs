using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 4: Exercise Tracking");

        /* List of Activities */
        List<Activity> activities = new List<Activity>();

        /* Running Activity */
        RunningActivity act1 = new RunningActivity(new DateTime(2023, 3, 24), 30, 3);
        activities.Add(act1);

        /* Cycling Activity */
        CyclingActivity act2 = new CyclingActivity(new DateTime(2023, 3, 21), 35, 15);
        activities.Add(act2);

        /* Swimming Activity */
        SwimmingActivity act3 = new SwimmingActivity(new DateTime(2023, 3, 29), 40, 35);
        activities.Add(act3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}