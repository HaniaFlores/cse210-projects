using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Random random = new Random();
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
        };

        int scriptureListIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[scriptureListIndex];

        while (!scripture.IsCompletelyHidden())
        {    
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            } else {
                scripture.HideWords();
            }
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have memorized the scripture!");
                break;
            }

        }
    }
}