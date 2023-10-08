using System;
using System.Runtime.CompilerServices;


// Class Journal Its used to Hold and Display Information on Journal Entrys 
public class Journal
{
    private List<Entry> entries;
    private string fileName = "";
    public Journal()
    {
        entries = new List<Entry>();
        
    }
    

    public void NewEntry()
    {
        PromptHolder promptHolder = new PromptHolder();
        Console.WriteLine("Is this Journl Entry from today? y/n");
        string userInput = Console.ReadLine();
        string date = DateTime.Now.ToString("MMMM dd yyyy");
        switch(userInput.ToLower())
        {
            case "y":
                Console.WriteLine($"Great Today's Date is {date}");
                break;

            case "n":
                Console.WriteLine("What is the date? dd/mm/yyyy");
                date = Console.ReadLine();
                break;

            default:
                Console.WriteLine("Please Type Y/N");
                return;
        }
        string randomPrompt = promptHolder.ChooseRandomPrompt();
        Console.WriteLine(randomPrompt);
        string response = Console.ReadLine();
        entries.Add(new Entry(date, randomPrompt, response));
        
    }
    public void DisplayEntrys()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ReturnString());
        }

    }
    public void SaveJournal()
    {
        if(fileName == "")
        {
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();
        }
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {  
            foreach (var item in entries)
            outputFile.WriteLine(item.ReturnString());
        }
    }
    public void LoadJournal()
    {
        entries.Clear();
        if(fileName == "")
        {
            Console.WriteLine("What is the name of the file?");
            fileName = Console.ReadLine();
        }
        string[] lines= System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] chuncks = line.Split(",");
            Console.WriteLine($"{chuncks[0]} {chuncks[1]} {chuncks[2]}");
            entries.Add(new Entry(chuncks[0], chuncks[1], chuncks[2]));
        }

    }
}
