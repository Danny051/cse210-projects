using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int mNumber = int.Parse(magicNumber);
        
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 11);
        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            // Console.Write("What is your guess? ");
            // string guessNumber = Console.ReadLine();

            int gNumber = 0;
            int guess_count = 0;

            while (mNumber != gNumber)
            {
                Console.Write("What is your guess? ");
                gNumber = int.Parse(Console.ReadLine());
                guess_count++;

                if (mNumber > gNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (mNumber < gNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                }
            }
            Console.WriteLine($"It took you {guess_count} guesses");
            
            
            Console.Write("Would you like to play again? ");
            keepPlaying = Console.ReadLine();
        }
        // else
        // {
        //     Console.Write("Thank you for playing. Goodbye.");
        // }
    }
}