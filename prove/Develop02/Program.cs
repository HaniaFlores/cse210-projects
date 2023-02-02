using System;

class Program
{
    static void Main(string[] args)
    {
        //Menu
        static void DisplayIntro() {
            Console.WriteLine("\nWelcome to the Journal Program");
        };


        static string DisplayMenu() {
            bool isInputValid = false;
            string selectedOption = "";

            do
            {
                Console.WriteLine("\nSelect the action:");
                Console.WriteLine("1. Entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Clear Journal");
                Console.WriteLine("6. Quit");
                selectedOption = Console.ReadLine().Trim();
                
                if (selectedOption == "1" || selectedOption == "2" || selectedOption == "3" || selectedOption == "4" || selectedOption == "5")
                {
                    isInputValid = true;
                }
                else {
                    Console.WriteLine($"{selectedOption} is not a valid option. Please choose 1 - 6");
                }

            } while (!isInputValid);

            return selectedOption;

        }
        
        DisplayIntro();
        string selectedOption;
        Journal myJournal = new Journal();
        Entry myEntry = new Entry();

        do
        {
            selectedOption = DisplayMenu();
            switch (selectedOption)
            {
                case "1":
                    myEntry.AddEntry();
                    break;
                case "2":
                    myEntry.Display();
                    break;
                case "3":
                    myJournal.UserFile();
                    myJournal.LoadFromFile();
                    break;
                case "4":
                    myJournal.UserFile();
                    myJournal.SaveToFile();
                    break;
                case "5":
                    myJournal.UserFile();
                    myJournal.ClearJournal();
                    break;
                default:
                    break;
            }   
        } while (selectedOption != "7");

    }
}