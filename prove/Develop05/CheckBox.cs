using System.Reflection.PortableExecutable;

public class CheckBoxGoal : Goal{
    private bool _completed = false;
    private int _checksCompleted;
    private int _checks;
    private int _bonus;
    public CheckBoxGoal() {

    }
    public CheckBoxGoal(string Name, string Description, int Score, int Checks, int ChecksCompleted, bool Completed){
        base.Score = Score;
        base.Description = Description;
        base.Name = Name;
        _checks = Checks;
        _checksCompleted = ChecksCompleted;
        _completed = Completed;
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
        if (!_completed){
            _checksCompleted ++;
            if (_checksCompleted >= _checks){
                ChangeScore("+", _bonus);
                _completed = true;
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
    public override void ReturnGoal()
    {
        if (_checksCompleted >= _checks){
            Console.WriteLine($"[X] {base.Name}, {base.Description}, {_checksCompleted}/{_checks}");
        }
        else {
            Console.WriteLine($"[-] {base.Name}, {base.Description}, {_checksCompleted}/{_checks}");

        }
    }  
        public override string SaveInfo()
    {
        return $"CheckBox*{base.Name}*{base.Description}*{base.Score}*{_checks}*{_checksCompleted}*{_completed}";
    }
}
