using System.Runtime.InteropServices;
using System.Transactions;

class Listing_Activity : Activity
{
    private Random random = new Random();
    private List<string> prompts = new List<string>()
    {
        "Who makes you smile?",
        "Your top personal strengths?",
        "Helped anyone this week?",
        "Recent moments of happiness?",
        "Personal heroes you admire?",
        "A recent act of kindness?",
        "A small daily joy?",
        "A moment you felt loved?",
        "A current source of inspiration?",
        "Something you're grateful for today?"
    };

    public Listing_Activity(int type) : base(type)
    {
        SetDiscription("This activity encourages you to ponder the positive aspects of your life by tasking you with creating a comprehensive list of as many things as possible within a specific area.");

    }

    public void Listing()
    {
        Start();
        int length = GetLength();
        string prompt = Prompt();
        Console.WriteLine(prompt);
        Console.WriteLine("When you are ready press enter.");
        Console.ReadLine();
        Console.Write("Starting In: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        Console.WriteLine($"Prompt:{prompt}");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length);
        int items = 0;
        while (DateTime.Now < futureTime)
        {
            string input = Console.ReadLine();
            items ++;
        }
        Console.WriteLine($"You Wrote This many items:{items}");
        Console.WriteLine("Great Job!");
        End();


    }
    private string Prompt()
    {
        int randomindex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomindex];
        return randomPrompt;
    }
}