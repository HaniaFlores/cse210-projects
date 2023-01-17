public class Resume
{
    public string _name = "";

    //Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Iterate through each Job instance in the list of jobs and display them.
        // Job is the Data Type.
        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }
}