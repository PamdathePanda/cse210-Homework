using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        double userNumber = PromptUserNumber();
        double squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName, squaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome To Prep 5 Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your Username?");
        string userName = Console.ReadLine();
        return userName;
    }
    static double PromptUserNumber()
    {
        Console.WriteLine("What is your Favorite Number?");
        string userInput = Console.ReadLine();
        double userNumber = double.Parse(userInput);
        return userNumber;
    }
    static double SquareNumber(double userNumber)
    {
        double squaredNumber = Math.Pow(userNumber, 2); 
        return squaredNumber;
    }
    static void DisplayResults(string userName, double squaredNumber)
    {
        Console.WriteLine($"Hello! Welcome back, {userName}, the square of your favorite number is:{squaredNumber}");

    }
}