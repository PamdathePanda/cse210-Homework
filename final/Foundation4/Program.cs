using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Cycling(new DateTime(2023, 12, 12), 30, 20),
            new Running(new DateTime(2023, 12, 12), 30, 5),
            new Swimming(new DateTime(2023, 12, 12), 30, 10)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}