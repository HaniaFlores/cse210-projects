using System;

class Program
{
    static void Main(string[] args)
    {

        string userInput = "yes"; 

        while (userInput.ToLower() == "yes")
        {
            //Computer select a random number.
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            //Ask user for a guess.
            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());
            
            int tries = 1;

            //Will run the loop when user does not guess the number at first try.
            while (userGuess != number) {
                
                if (userGuess < number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    userGuess = int.Parse(Console.ReadLine());
                    tries += 1;
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    userGuess = int.Parse(Console.ReadLine());
                    tries +=1;
                }
            }

            //Print the number of tries user made.
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {tries} guesses.");

            //Ask user if he want to play again.
            Console.Write("Do you want to play again? ");
            userInput = Console.ReadLine();

        }
            
        Console.WriteLine("Thank you for playing.");

    }
}