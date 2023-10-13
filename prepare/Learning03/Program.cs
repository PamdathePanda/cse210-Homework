using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction(1, 1);
        Fraction wholeNumer = new Fraction(10);
        Fraction empty = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(wholeNumer.GetFractionString());
        Console.WriteLine(empty.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(wholeNumer.GetDecimalValue());
        Console.WriteLine(empty.GetDecimalValue());


    }
}