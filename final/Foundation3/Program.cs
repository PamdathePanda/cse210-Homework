using System;

class Program
{
    static void Main(string[] args)
    {

        Address lectureEventAddress = new Address("456 Oak St", "Townsville", "NY", "USA");
        Address outdoorEventAddress = new Address("789 Pine St", "Villageton", "TX", "USA");
        Address receptionEventAddress = new Address("101 Elm St", "Hamletsville", "FL", "USA");

        Lecture lectureEvent = new Lecture("Programming 101", "Introduction to C#", DateTime.Now, DateTime.Now.AddHours(2), lectureEventAddress, "Lecture", "John Doe", 100);
        Outdoor outdoorEvent = new Outdoor("Summer Picnic", "Join us for a fun day outdoors", DateTime.Now, DateTime.Now.AddHours(2), outdoorEventAddress, "Outdoor", "Sunny");
        Reception receptionEvent = new Reception("Networking Mixer", "Connect with professionals in your industry", DateTime.Now, DateTime.Now.AddHours(2), receptionEventAddress, "Reception", "rsvp@example.com");
        
        
        Console.WriteLine("\nLecture Event Details:");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine(lectureEvent.ShortDescription());

        Console.WriteLine("\nOutdoor Event Details:");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine(outdoorEvent.ShortDescription());

        Console.WriteLine("\nReception Event Details:");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine(receptionEvent.ShortDescription());
    }
}