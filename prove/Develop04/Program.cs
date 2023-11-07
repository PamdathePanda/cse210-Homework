using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop == true){
            Console.WriteLine("Welcome to the RestCenter, Please Choose an activity to relax and rest");
            Console.WriteLine("1:Breathing Activity");
            Console.WriteLine("2:Reflection Activity");
            Console.WriteLine("3:Listing Activity");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;                   
                case "quit":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Error, Please Retry");
                    break;  
            }
            Console.WriteLine();
            Console.WriteLine();
            input = Console.ReadLine();
            int intInput = int.Parse(input);
        }
    }
}