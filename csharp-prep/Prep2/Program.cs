using System;
using System.ComponentModel;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop == true)
        {
            bool gradePlus = true;
            bool gradeMinus = true;
            Console.WriteLine("What was your Grade Percentage:");
            string percentStr = Console.ReadLine();
            if (percentStr == "exit")
            {
                loop = false;
                break;
            }
            int percentNum = int.Parse(percentStr);
            string letterGrade = "NA";
            string gradeSymbol = "";
            string endText = "";
            if (percentNum >= 90)
            {
                letterGrade = "A";
                gradePlus = false;
                if (percentNum == 100)
                {
                    gradeMinus = false;
                }
            }
            else if (percentNum >= 80)
            {
                letterGrade = "B";
            }
            else if (percentNum >= 70)
            {
                letterGrade = "C";
            }
            else if (percentNum >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
                gradeMinus = false;
                gradePlus = false;
            }

            if (percentNum >= 70)
            {
                endText = "You Passed! Congradulations!";
            }
            else
            {
                endText = "Try Again! Remember 'The most important step is the next one' -The Way of Kings";
            }
            //determine if its a plus or minus grade
            if (gradePlus == true)
            {
                if (percentNum % 10 >= 7)
                {
                    gradeSymbol = "+";
                }
            }
            if (gradeMinus == true)
            {
                if (percentNum % 10 <= 3)
                {
                    gradeSymbol = "-";
                }
            }
            Console.WriteLine($"Final Grade:{gradeSymbol}{letterGrade}, {endText}");
        }
       
    }
}