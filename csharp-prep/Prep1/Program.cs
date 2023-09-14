using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        Console.Write("What is your grade? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        
        string letter = "";
        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
        
        if (x >= 70)
            {
                Console.WriteLine("You passed!");
            }
        else
            {
                Console.WriteLine("Better luck next time!");
            }
    }
}