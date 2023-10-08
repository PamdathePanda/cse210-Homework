using System;
using System.Runtime.CompilerServices;

// Class Program Used to execute and control other classes.
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptHolder promptHolder = new PromptHolder();
        
        bool exit = false;
        while (exit == false)
        {
            Console.WriteLine("1. Write in Journal");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal As File");
            Console.WriteLine("4. Load Journal From File");
            Console.WriteLine("5. Make a new Prompt");
            Console.WriteLine("6. Display Prompts");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your Choice");
            string menuChoice = Console.ReadLine();
            
            switch (menuChoice)
            {
                case "1":
                    journal.NewEntry();
                    break;
                case "2":
                    journal.DisplayEntrys();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    promptHolder.CreatePrompt();
                    break;
                case "6":
                    promptHolder.DisplayPrompts();
                    break;
                case "7" :
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please make a Selection");
                    break;
            }
        }

    }
}
