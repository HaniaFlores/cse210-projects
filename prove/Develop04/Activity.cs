public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity (string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell Done!!");
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        Thread.Sleep(1000);
    }
    
    public void ShowSpinner()
    {
        List<string> animationList = new List<string>{};
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationList[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if( i >= animationList.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int s = seconds; s > 0; s--)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}