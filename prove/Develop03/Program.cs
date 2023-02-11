using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // --- EXCEEDING REQUIREMENTS --- 
        // *** This program works with a library of scriptures rather than a single one. 
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("D&C", 58, 42, 43), "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more; by this ye may know if a man repenteth of his sins—behold, he will confess them and forsake them."),
            new Scripture(new Reference("Psalm", 119, 105), "Thy word is a lamp unto my feet, and a light unto my path.")
        };

        // *** Chooses a scripture randomly to present to the user.
        int scriptureListIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[scriptureListIndex];

        while (true)
        {    
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine();
            Console.Write("\nPress Enter to hide words or type 'quit' to exit. ");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("\nThanks for playing! Have a great day.");
                break;
            } 
            else { scripture.HideWords(); }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine("\nCongratulations! You have memorized the scripture!");
                break;
            }
            
        }
    }
}