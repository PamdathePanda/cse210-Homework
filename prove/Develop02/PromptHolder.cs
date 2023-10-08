using System;
using System.Runtime.CompilerServices;


// Class Journal Its used to Hold and Display Information on Journal Entrys 
public class PromptHolder
{
    private List<Prompt> prompts;
    private string[] builtInPrompts = 
    {
        "What tasks or responsibilities did you complete today? How do you feel about your productivity?",
        "Can you recall a recent challenge or obstacle you faced? How did you overcome it, or what did you learn from it?", 
        "What are three things you're grateful for today, and what makes them special to you?",
        "Write a letter to your future self. What advice or hopes do you have for your future?",
        "What personal goal are you currently working towards, and what steps have you taken to achieve it?",
        "Can you recall a funny or embarrassing moment from your day?",
        "What challenges or difficulties are you currently facing, and what strategies are you using to cope with them",
        "Is there a particular song, book, or quote that made you happy today?"
    };
    public PromptHolder()
    {
        prompts = new List<Prompt>();
        //Checks if a prompts file exists if it does then i loads it uses built in prompts and creates a prompt file to store prompts
        if (System.IO.File.Exists("prompts.txt"))
        {
            LoadPrompts();
        }
        else
        {
            foreach (var line in builtInPrompts)
            {
                prompts.Add(new Prompt(line));
            }  
        }
    }
    public void CreatePrompt()
    {
        Console.WriteLine("What is the new Prompt?");
        string userInput = Console.ReadLine();
        prompts.Add(new Prompt(userInput));
        SavePrompts();
    }
    public void DisplayPrompts()
    {
        foreach(var prompt in prompts)
        {
            Console.WriteLine(prompt.ReturnString());
        }
    }

    public string ChooseRandomPrompt()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex].ReturnString();
        return randomPrompt;
    }
    private void SavePrompts()
    {
        using(StreamWriter outputFile = new StreamWriter("prompts.txt"))
        {  
            foreach (var item in prompts)
            outputFile.WriteLine(item.ReturnString());
        }
    }

    private void LoadPrompts()
    {
        prompts.Clear();
        string[] lines= System.IO.File.ReadAllLines("prompts.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            prompts.Add(new Prompt(line));
        }

    }
}
