using System;

class Program
{
    static void Main(string[] args)
    {
        //Menu
        static void DisplayIntro() {
            Console.WriteLine("Welcome to the Journal Program");
        };

        static void DisplayMenu() {
            Console.WriteLine("Select the action:");
            Console.WriteLine("1. Entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }
        
        DisplayIntro();
        DisplayMenu();
        Journal myJournal = new Journal();
        Entry myEntry = new Entry();

        string selectedOption = Console.ReadLine();

        while (selectedOption != "5"){
            if (selectedOption == "1"){
                myEntry.AddEntry();
                DisplayMenu();
                selectedOption = Console.ReadLine();
            }
            else if (selectedOption == "2"){
                myEntry.Display();
                DisplayMenu();
                selectedOption = Console.ReadLine();
            }
            else if (selectedOption == "3"){
                myJournal.LoadFromFile();
                DisplayMenu();
                selectedOption = Console.ReadLine();
            }
            else if (selectedOption == "4"){
                myJournal.SaveToFile();
                DisplayMenu();
                selectedOption = Console.ReadLine();
            }
            else if (selectedOption == "5"){
                break;
            }

        }

    }
}