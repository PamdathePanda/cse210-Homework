class Breathing_Activity : Activity
{
    private int length;


public Breathing_Activity(int type) : base(type)
{
    SetDiscription("This activity is designed to promote relaxation by guiding you through slow, mindful breathing. It encourages you to clear your mind and concentrate on your breath as you inhale and exhale");
}

public void Breath()
{
    Start();
    length = GetLength();    
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(length);
    int i = 0;
    int seconds = 8;
    bool BreathSwitch = true;
    while (DateTime.Now < futureTime)
    {   
        if (seconds >= 6)
        {
            seconds = 0;
            switch (BreathSwitch)
            {
                case true:
                    Console.Clear();
                    Console.WriteLine("Breath In...");
                    BreathSwitch = false;
                    break;
                case false:
                    Console.Clear();    
                    Console.WriteLine("Breath Out...");
                    BreathSwitch = true;
                    break;
            } 
        }
        string s = anim[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i++;
        if (i >= 8)
        {
            i = 0;
        }
        seconds++;        

    }
    
    End();

}

}

