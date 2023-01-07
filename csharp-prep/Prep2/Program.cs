using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user their grade.
        Console.Write("Insert your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;
        int sign = grade % 10;
        
        //Printing the letter grade.
        if (grade >= 90)
        {
            if (sign < 3)
            {
                letter = "A-";
            }

            else
            {
                letter = "A";
            }
        }

        else if (grade >= 80)
        {
            if (sign >= 7)
            {
                letter = "B+";
            }

            else if (sign < 3)
            {
                letter = "B-";
            }

            else
            {
                letter = "B";
            }
        }

        else if (grade >= 70)
        {
            if (sign >= 7)
            {
                letter = "C+";
            }

            else if (sign < 3)
            {
                letter = "C-";
            }

            else
            {
                letter = "C";
            }
        }

        else if (grade >= 60)
        {
            if (sign >= 7)
            {
                letter = "D+";
            }

            else if (sign < 3)
            {
                letter = "D-";
            }

            else
            {
                letter = "D";
            }
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        //Print if you passed or not the course.
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }

        else
        {
            Console.WriteLine("Keep trying to get a higher score next time.");
        }

    }
}