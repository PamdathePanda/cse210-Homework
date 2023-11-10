using System.Xml;

class Reflection_Activity : Activity
{
    private Random random = new Random();
    private List<string> prompts = new List<string>() 
    {
        "Recall a moment when you overcame a significant obstacle.",
        "Consider a time when you took a risk that paid off.",
        "Reflect on a situation when you learned a valuable life lesson.",
        "Think of a time when you made a positive impact on someone's life.",
        "Recall a moment when you faced your fears and conquered them.",
        "Reflect on a situation when you demonstrated patience and resilience.",
        "Consider a time when you achieved a personal milestone or goal.",
        "Think of a time when you expressed gratitude or received it from someone else.",
        "Recall a moment when you collaborated effectively with others to achieve a common goal.",
        "Reflect on a situation when you took a chance and it led to personal growth."
    };
    private List<string> questions = new List<string>()
    {
        "How did this experience impact your perspective on life?",
        "Did you encounter any unexpected challenges during this experience? How did you handle them?",
        "What motivated you to undertake this experience in the first place?",
        "Did you receive any support or guidance from others during this experience?",
        "What skills or qualities did you rely on to succeed in this endeavor?",
        "Were there any moments of doubt or uncertainty along the way? How did you overcome them?",
        "How did this experience shape your future goals and aspirations?",
        "Did this experience change your relationship with someone, and if so, how?",
        "In what ways did you step out of your comfort zone during this experience?",
        "How might this experience influence your decision-making in the future?"
    };
    public Reflection_Activity(int type) : base(type)
    {
        SetDiscription("This Activity will prompt you to contemplate instances in your life when you've demonstrated fortitude and tenacity. Doing so will enable you to acknowledge the strength within you and how you can apply it to various facets of your life.");
        
    }
    public void Reflection()
    {
        Start();
        int length = GetLength();
        string prompt = Prompt();
        Console.WriteLine(prompt);
        Console.WriteLine("When you are ready to move on press enter.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Ponder on the following questions as they relate to your experience");
        Wait(5);
        Console.Clear();
        Console.WriteLine($"{prompt} \n");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(Question());
            Wait(5);
        }
        End();
    }
    private string Prompt()
    {
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        return randomPrompt;
    }
    private string Question()
    {
        int randomIndex = random.Next(questions.Count);
        string randomQuestion = questions[randomIndex];
        return randomQuestion;
    }
}