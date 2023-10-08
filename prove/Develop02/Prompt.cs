public class Prompt
{
    public string _prompt { get; set;}


    public Prompt(string inputPrompt)
    {
        _prompt = inputPrompt;
    }
    public string ReturnString(){
        return _prompt;
    }
}