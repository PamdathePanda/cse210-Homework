using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int inputNumber = 0;

        while (inputNumber != magicNumber)
        {
            Console.WriteLine("Whats the Magic Number?");
            string input = Console.ReadLine();
            inputNumber = int.Parse(input);
            if (inputNumber != magicNumber)
            {
                if (inputNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                if (inputNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
        }
        Console.WriteLine($"{magicNumber}, your Number {inputNumber}");
        Console.WriteLine("you got it Right! Nice Job!");

    }
}