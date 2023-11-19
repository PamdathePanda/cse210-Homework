using System.Reflection.PortableExecutable;

public class CheckBoxGoal : Goal{
    private bool completed = false;
    private int _checksCompleted;
    private int _checks;
    private int _bonus;
    public CheckBoxGoal() {

    }
    public override void Initiate()
    {
        base.Initiate();
        Console.WriteLine("How many times do you want to complete this goal to gain a bonus? :");
        _checks = int.Parse(Console.ReadLine());
        Console.WriteLine("How much is the bonus worth? :");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override int Progress()
    {
        if (!completed){
            _checksCompleted ++;
            if (_checksCompleted >= _checks){
                ChangeScore("+", _bonus);
                completed = true;
                return GainScore();
            }
            else{
                return GainScore();    
            }
        }
        else{
            Console.WriteLine("This Goal is Already Completed");
            return 0;
        }

    }
    public override string ReturnGoal()
    {
        if (_checksCompleted >= _checks){
            Console.WriteLine($"[X] {base.Name}, {base.Description}, {_checksCompleted}/{_checks}");
        }
        else {
            Console.WriteLine($"[-] {base.Name}, {base.Description}, {_checksCompleted}/{_checks}");

        }




       return ""; 
    }  
}
