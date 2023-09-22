using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

class Program
{
    
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool loop = true;
        Console.WriteLine("Lets Create a List of Numbers!");
        while (loop == true)
        {
            Console.Write("Type 0 to Exit ");
            Console.WriteLine("Enter A Number:");
            string inputStr = Console.ReadLine();
            int inputNumber = int.Parse(inputStr);
            if (inputStr.ToLower() == "exit" || inputNumber == 0)
            {
                loop = false;
                break;
            }
            numbers.Add(inputNumber);
        }
        Console.WriteLine($"here are the numbers you entered ");

        int total = 0;
        double min = double.PositiveInfinity;
        int max = 0; 
        int count = 0;
        // Sum Total
        foreach (int number in numbers)
        {   
            count += 1;
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            total = total + number;
        }
        int average = total / count;
        Console.WriteLine($"Total:{total}, Max:{max}, Min:{min}, Average:{average}");
    }
}