using System;
using System.Runtime.CompilerServices;

// Class Program Used to execute and control other classes.
class Program
{
    static void Main()
    {
        Journal MyJournal = new Journal();
        
        bool exit = false;
        while (exit == false)
        {
            Console.WriteLine("1. Write in Journal");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal As File");
            Console.WriteLine("4. Open Journal");
            Console.WriteLine("Enter your Choice");
            string menuChoice = Console.ReadLine();
            
            switch (menuChoice)
            {
                case "1":
                    MyJournal.NewEntry();
                    break;
                case "2":
                    MyJournal.DisplayEntrys();
                    break;
                case "3":
                    Console.WriteLine("3");
                    break;
                case "4":
                    Console.WriteLine("4");
                    break;
                case "5" :
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Please make a Selection");
                    break;
            }
        }

    }
}
