public class SimpleGoal : Goal {

    private bool _isComplete = false;

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
    public override string ReturnGoal()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {base.Name}, {base.Description}");
        }
        else
        {
            Console.WriteLine($"[-] {base.Name}, {base.Description}");
        }

        return ""; 
    }

}