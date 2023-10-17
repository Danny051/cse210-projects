using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction(); // Don't pass any information to get the default values
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetTop());


        Fraction f2 = new Fraction(5); // pass the top number
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetTop());


        Fraction f3 = new Fraction(3,4); // pass all top and bottom numbers
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        
    }

}