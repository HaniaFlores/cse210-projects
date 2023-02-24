using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 1;
        while (response > 0 && response < 4) {
            //Menu Options
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            response = Convert.ToInt32(Console.ReadLine());

            //Function that returns the endTime for the activity.
            static DateTime GetEndTime(int seconds)
            {
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(seconds);
                return endTime;
            }

            Console.Clear();
            switch (response)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity
                    ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    DateTime endTime = GetEndTime(breathing.GetDuration());
                    while (DateTime.Now < endTime)
                    {
                        breathing.RunActivity();
                    }
                    breathing.DisplayEndMessage();
                    Console.Write("\nPress Enter to return to the Menu.");
                    Console.ReadKey();
                    break;
                
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity
                    ("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.Clear();

                    endTime = GetEndTime(reflecting.GetDuration());
                    while (DateTime.Now < endTime)
                    {
                        reflecting.RunActivity();
                        Console.WriteLine();
                    }
                    reflecting.DisplayEndMessage();
                    Console.Write("\nPress Enter to return to the Menu.");
                    Console.ReadKey();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity
                    ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    endTime = GetEndTime(listing.GetDuration());
                    while (DateTime.Now < endTime)
                    {
                        listing.RunActivity();
                    }
                    int items = listing.GetResponses();
                    Console.WriteLine($"You have listed {items} items");
                    listing.DisplayEndMessage();
                    Console.Write("\nPress Enter to return to the Menu.");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Goodbye. See you soon.");
                    break;
            };
        };


    }
}