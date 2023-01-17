using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user to enter a list of numbers.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float userInput = 1;
        //Create a list of integers called numbers.
        List<float> numbers = new List<float>();

        //Program continue asking for a number until user type 0.
        //Add each number entered by the user in a list.
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = float.Parse(Console.ReadLine());
            //Doesn't add 0 to the list.
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }

        //Iterate through the list to sum the numbers and print the total.
        float sum = 0;
        float largestNumber = 0;
        float smallestPositive = 10000000000000000;

        foreach (float number in numbers)
        {
            sum += number;
            //Evaluate the numbers to find the largest among them.
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            else if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average.
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the largest number.
        Console.WriteLine($"The largest number is: {largestNumber}");

        //Find the smallest positive number.
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        //Sort and print the list.
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (float num in numbers)
        {
            Console.WriteLine(num);
        }
        
    }
}