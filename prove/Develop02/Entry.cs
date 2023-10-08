
public class Entry
{
    public string _date { get; set;}
    public string _prompt { get; set;}
    public string _userResponse { get; set;}


    public Entry(string Date, string Prompt, string Response)
    {
        _date = Date;
        _prompt = Prompt;
        _userResponse = Response;

    }
    public string ReturnString()
    {
        return $"Date:{_date}, Prompt:{_prompt}, Response:{_userResponse}";
    }
}