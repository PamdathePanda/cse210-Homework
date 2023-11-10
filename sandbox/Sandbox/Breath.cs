using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Breath
{
    List<string> anim = new List<string>();
    public Breath()
    {
        anim.Add("|");
        anim.Add("/");
        anim.Add("-");
        anim.Add("\\");
        anim.Add("|");
        anim.Add("/");
        anim.Add("-");
        anim.Add("\\");
    }
    public void Time(int length)
    {

   DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(length);
    int i = 0;
    int seconds = 8;
    bool BreathSwitch = true;
    while (DateTime.Now < futureTime)
    {   
        if (seconds >= 8)
        {
            seconds = 0;
            switch (BreathSwitch)
            {
                case true:
                    Console.Clear();
                    Console.WriteLine("Breath In");
                    BreathSwitch = false;
                    break;
                case false:
                    Console.Clear();    
                    Console.WriteLine("Breath Out");
                    BreathSwitch = true;
                    break;
            } 
        }
        string s = anim[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
        i++;
        if (i >= 8)
        {
            i = 0;
        }
        seconds++;        

    }

    }

}