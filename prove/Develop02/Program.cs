using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Let's start with your name for the day: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hi, {userName}");
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        int userOption = -1;
        while (userOption != 5)    
        {
            // Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("\nPlease select one of the following choices(1-5):");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();
            userOption = int.Parse(option);
            if (userOption == 1)
            {
                // insert prompt here
                string prompt = promptGenerator.RandomPromptGenerator();
                journal.AddEntry(prompt);
            }
            else if (userOption == 2)
            {
                // display journal entries here
                journal.DisplayJournal();
            }
            else if (userOption == 3)
            {
                // save entries from journal to a file created by user
                journal.SaveToFile();
            }
            else if (userOption == 4)
            {
                // read and load entries from journal to a file created by user
                journal.LoadFromFile();
            }
            else if (userOption == 5)
            {
            Console.Write($"See you next time {userName}");
            }
        }
    }
}
// I exceeded the requirements for this assignment by saving some information in the journal entry.
// And also storing the user's name to make the program user friendly and the name may also appear in some prompts.