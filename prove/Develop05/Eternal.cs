using System.Reflection.Metadata.Ecma335;

public class EternalGoal : Goal{
    public EternalGoal(){
        
    }
    public override int Progress()
    {
        return GainScore();
    }
    public override string ReturnGoal()
    {
        Console.WriteLine($"Name: {base.Name}, Score: {base.Score}, Description: {base.Description}");

        return "3"; 
    }


}