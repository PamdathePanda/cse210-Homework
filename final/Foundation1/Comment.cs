public class Comment{

    public string _name;
    public string _text;

    public Comment(string Name, string Text){
        _name = Name;
        _text = Text;
    }
    public string ReturnInfo(){
        return $" {_name}, {_text}";
    }
}