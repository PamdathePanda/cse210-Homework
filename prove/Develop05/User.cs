/* using System.Security.Cryptography.X509Certificates; */

/* class User{
    string fileName = "Error";
    private int _totalScore;
    private string _name;
    private List<Goal> goals = new List<Goal>();
    public User(string name){
        _totalScore = 0;
        _name = name;
        fileName = name;
    }
    public void AddScore(int score){
        _totalScore += score;
    }
    public int ReturnScore(){
        return _totalScore;
    }



    public void SaveUser()
    {
        if(fileName == "")
        {
        fileName = _name;
        }
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {  
            foreach (var item in goals)
            outputFile.WriteLine($"Completed:{item.CheckForComplete()}");
        }
    }
    public void LoadUser(string fileName)
    {
        if(fileName == "")
        {
            Console.WriteLine("What is the name of the file?");
            fileName = Console.ReadLine();
        }
        string[] lines= System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] chuncks = line.Split(",");
            Console.WriteLine($"{chuncks}");
            goals.Add(new Goal(1, "John"));
        }
    }
} */ 
class yourMom{
    
}