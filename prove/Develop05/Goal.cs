using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Reflection;

public abstract class Goal{
    private int _score;
    private string _name;
    private string _description;

    public abstract int Progress();

    //public abstract int GainScore();
    public void ChangeScore(string type, int value){
        switch (type)
        {
            case "+":
                _score += value;
                break;
            case "-":
                _score -= value;
                break;
            case "=":
                _score = value;
                break;
        }
    }
    public virtual void Initiate(){
        Console.WriteLine("What is the name of the goal? :");
        _name = Console.ReadLine();
        Console.WriteLine("Give it a small Description :");
        _description = Console.ReadLine();
        Console.WriteLine("How Many Points is it worth? :");
        _score = int.Parse(Console.ReadLine());
    }
    public int GainScore(){
        Console.WriteLine($"You Scored! nice job! You Scored:{_score}");
        return _score;
    }
    public abstract string SaveInfo();

    public abstract void ReturnGoal();


    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    


}