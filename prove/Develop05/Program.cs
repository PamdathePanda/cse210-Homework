using System;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        bool menuLoop = true;
        int choice;
        int _totalScore = 0;

        while (menuLoop == true){
            Console.WriteLine($"Score: {_totalScore}");
            Console.WriteLine("1: Create Goals");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Show Score");
            Console.WriteLine("4: Complete a Goal");
            Console.WriteLine("5: Save");
            Console.WriteLine("6: Load");
            Console.WriteLine("7: Quit");

            choice = int.Parse(Console.ReadLine());
            int start;
            int index;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1: Create Simple Goal");
                    Console.WriteLine("2: Create CheckBox Goal");
                    Console.WriteLine("3: Create Eternal Goal"); 
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
            
                        case 1:
                            goals.Add(new SimpleGoal());
                            index = goals.Count() - 1;
                            goals[index].Initiate();
                            goals[index].ReturnGoal();
                            break;
                        case 2:
                            goals.Add(new CheckBoxGoal());
                            index = goals.Count() - 1;
                            goals[index].Initiate();
                            break;
                        case 3:
                            goals.Add(new EternalGoal());
                            index = goals.Count() - 1;
                            goals[index].Initiate();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    break;

                case 2:
                    start = 1;
                    foreach(Goal goal in goals)
                    {
                        Console.Write($"{start}: ");
                        start ++;
                        goal.ReturnGoal();
                    }
                    break;
                case 3:
                    Console.WriteLine($"Your Score is {_totalScore}");
                    break;
                case 4:
                    start = 1;
                    if (goals.Count() <= 0){
                        Console.WriteLine("There are no Goals to Complete");
                        break;
                    }
                    foreach(Goal goal in goals)
                    {
                        Console.Write($"{start}: ");
                        start ++;
                        goal.ReturnGoal();
                    }
                    choice = int.Parse(Console.ReadLine()) - 1;
                    _totalScore += goals[choice].Progress();
                    goals[choice].ReturnGoal();
                    Thread.Sleep(2);
                    
                    break;
                case 5:
                //Save
                    Console.WriteLine("What is the UserName?");
                    string fileName = Console.ReadLine();
                    using(StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
                    {  
                        outputFile.WriteLine(_totalScore);
                        for (index = 0; index < goals.Count; index++)
                        {
                                outputFile.WriteLine(goals[index].SaveInfo());
                        }
                    }
                    break;
                case 6:
                //Load
                    Console.WriteLine("What is the name of the file?");
                    fileName = Console.ReadLine();
                    bool firstLine = true;
                    string[] lines= System.IO.File.ReadAllLines($"{fileName}.txt");
                    foreach (string line in lines)
                    {
                        if (firstLine == true)
                        {
                            _totalScore = int.Parse(line);
                            firstLine = false;
                        }
                        else{
                            string[] chunck = line.Split("*");
                            Console.WriteLine($"{chunck[0]}");
                            switch (chunck[0]){
                                case "Simple":
                                    goals.Add(new SimpleGoal(chunck[1],chunck[2],int.Parse(chunck[3]),bool.Parse(chunck[4])));
                                    break;
                                case "CheckBox":
                                    goals.Add(new CheckBoxGoal(chunck[1],chunck[2],int.Parse(chunck[3]),int.Parse(chunck[4]),int.Parse(chunck[5]),bool.Parse(chunck[6])));
                                    break;
                                case "Eternal":
                                    goals.Add(new EternalGoal(chunck[1],chunck[2],int.Parse(chunck[3])));
                                    break;
                            }
                        }

                    }
                    break;
                case 7:
                    menuLoop = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Thread.Sleep(2);
            
        }
    }
}