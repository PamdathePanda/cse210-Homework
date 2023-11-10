using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int type;
        bool loop = true;
        while (loop == true){
            Console.WriteLine("Welcome to the RestCenter, Please Choose an activity to relax and rest");
            Console.WriteLine("1:Breathing Activity");
            Console.WriteLine("2:Reflection Activity");
            Console.WriteLine("3:Listing Activity");
            Console.WriteLine("4:Quit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    type = 1;   
                    Breathing_Activity breathing = new Breathing_Activity(type);
                    breathing.Breath();
                    break;
                case "2":
                    type = 2;
                    Reflection_Activity reflection = new Reflection_Activity(type);
                    reflection.Reflection();
                    break;
                case "3":
                    type = 3;
                    Listing_Activity listing = new Listing_Activity(type);
                    listing.Listing();
                    break;
                case "4":
                    loop = false;
                    break;                   
                case "quit":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Error, Please Retry");
                    break;  
            }
            

        }
    }
}