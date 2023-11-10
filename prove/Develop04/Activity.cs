using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

class Activity{
private int _type;
private int _length;
private string _description;
public List<string> anim = new List<string>();

public Activity(int type)
{
    anim.Add("|");
    anim.Add("/");
    anim.Add("-");
    anim.Add("\\");
    anim.Add("|");
    anim.Add("/");
    anim.Add("-");
    anim.Add("\\");
    _type = type;
}
public void SetDiscription(string description)
{
    _description = description;
}
public int GetLength()
{
    return _length;
}
public void Wait(int length)
{
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(length);
    int i = 0;
    while (DateTime.Now < futureTime)
    {   
        string s = anim[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");
        i++;
        if (i >= 8)
        {
            i = 0;
        }    

    }

} 
public void Start()
{
    Console.Clear();
    Console.WriteLine("Get Ready, Activity Loading: ");
    Wait(3);
    Console.Clear();
    string activity;
        switch (_type)
    {
        case 1: // Breathing
            activity = "Breathing";
            break;
        case 2: //Reflection
            activity = "Reflection";
            break;
        case 3: //Listing
            activity = "Listing";
            break;
        default: 
            activity = "Error";
            break;
    }
    Console.WriteLine($"Welcome to the {activity} Activity");
    Console.WriteLine(_description);
    Console.WriteLine("How many seconds would you like the activity to last?");
    string input = Console.ReadLine();
    _length = int.Parse(input);

}
public void End()
{
    string activity;
        switch (_type)
    {
        case 1: // Breathing
            activity = "Breathing";
            break;
        case 2: //Reflection
            activity = "Reflection";
            break;
        case 3: //Listing
            activity = "Listing";
            break;
        default: 
            activity = "Error";
            break;
    }
    Console.WriteLine("Great Job!");
    Console.WriteLine($"You Completed {_length} Seconds of Mindfullness!");
    Console.WriteLine($"Thank you for joining us for the {activity} Activity");
    Wait(3);
}

}