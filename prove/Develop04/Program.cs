using System;

class Program
{
    static void Main(string[] args)
    {
        //Menu Options
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("\nSelect a choice from the menu: ");
        string response = Console.ReadLine();

        //Function that returns the endTime for the activity.
        static DateTime GetEndTime(int seconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            return endTime;
        }

        Console.Clear();
        switch(response)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity
                ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                DateTime endTime = GetEndTime(breathing.GetDuration());
                while (DateTime.Now < endTime)
                {
                    breathing.RunActivity();
                }
                breathing.DisplayEndMessage();
                break;
        }

    }
}