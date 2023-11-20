public class SimpleGoal : Goal {

    private bool _isComplete = false;
    public SimpleGoal(){


    }
        public SimpleGoal(string Name, string Description, int Score, bool Completed){
        base.Score = Score;
        base.Description = Description;
        base.Name = Name;
        _isComplete = Completed;
    }
    public override int Progress()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
             return GainScore();                 
        }
        else{
            Console.WriteLine("This Goal is already completed");
            return 0;
        }

    }
    public override void ReturnGoal()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {base.Name}, {base.Description}");
        }
        else
        {
            Console.WriteLine($"[-] {base.Name}, {base.Description}");
        }
    }
    public override string SaveInfo()
    {
        return $"Simple*{base.Name}*{base.Description}*{base.Score}*{_isComplete}";
    }
}