using System;

class Program
{
    static void Main(string[] args)
    {
        /*Call each of the functions saving the return 
        values and passing data to them as necessary.*/
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int numberSqr = SquareNumber(num);
        DisplayResult(name, numberSqr);
    }

    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int num)
    {
        int numSqr = num * num;
        return numSqr;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int numberSqr)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSqr}");
    }
}