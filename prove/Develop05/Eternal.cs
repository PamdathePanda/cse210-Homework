using System.Reflection.Metadata.Ecma335;

public class EternalGoal : Goal{
    public EternalGoal(){
        
    }
    public EternalGoal(string Name, string Description, int Score){
        base.Score = Score;
        base.Description = Description;
        base.Name = Name;
    }
    public override int Progress()
    {
        return GainScore();
    }
    public override void ReturnGoal()
    {
        Console.WriteLine($"[-] {base.Name}, {base.Description}"); 
    }
        public override string SaveInfo()
    {
        return $"Eternal*{base.Name}*{base.Description}*{base.Score}";
    }


}