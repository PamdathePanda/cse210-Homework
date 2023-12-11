

using System.Dynamic;
using System.Linq.Expressions;
using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;

public class Video{

    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments;

    public Video(string Title, string Author, int Length, List<Comment> Comments){
        _title = Title;
        _author = Author;
        _length = Length;
        comments = Comments;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Video Title:{_title}, Author:{_author}, Length in Minutes:{_length}, Number of Comments:{comments.Count()}");
        foreach(var comment in comments){
            Console.WriteLine(comment.ReturnInfo());
        }
    }
}