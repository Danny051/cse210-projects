using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine("Math Assignment");
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine("\nWriting Assignment");
        Console.WriteLine(assignment2.GetWritingInformation());

    }
}