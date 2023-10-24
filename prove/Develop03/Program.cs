using System;
using System.Linq.Expressions;

class Program
{
    public static Scripture scripture;
    private static bool loop = true;

    static void Main(string[] args)
    {
        Console.WriteLine("Give a Reference and a Verse");
        //ask for reference
        Console.Write("\nReference:");
        string reference = Console.ReadLine();
        //ask for verse
        Console.Write("Verse:");
        string verse = Console.ReadLine();

        //initiate scipture
        scripture = new Scripture(reference, verse);
        
        while (loop == true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            string input = Console.ReadLine();
            //Check if they want to end early
            if (input.ToLower() == "quit")
            {
                break;
            }
            //check if every word is blank
            if (scripture.CheckforEnd() == true)
            {
                loop = false;
            }
            scripture.HideRandomWords(3);


        }


    }
}