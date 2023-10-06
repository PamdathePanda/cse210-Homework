using System;
using System.Runtime.CompilerServices;


// Class Journal Its used to Hold and Display Information on Journal Entrys 
public class Journal
{
    private List<Entry> entries;
    private string[] prompts = 
    {
        "Hi",
        "hello",
        "hold on"
    };

    public Journal()
    {
        entries = new List<Entry>();
    }
    

    public void NewEntry()
        {
        Console.WriteLine("Is this Journl Entry from today? y/n");
        string userinput = Console.ReadLine();
        string Date = DateTime.Now.ToString("MMMM dd yyyy");
        switch(userinput.ToLower())
        {
            case "y":
                Console.WriteLine($"Great Today's Date is {Date}");
                break;

            case "n":
                Console.WriteLine("What is the date? dd/mm/yyyy");
                Date = Console.ReadLine();
                break;

            default:
                Console.WriteLine("Please Type Y/N");
                return;
        }
        string Prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(Prompt);
        string Response = Console.ReadLine();
        entries.Add(new Entry(Date, Prompt, Response));
        
    }
    public void DisplayEntrys()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ReturnString());
        }

    }
}
