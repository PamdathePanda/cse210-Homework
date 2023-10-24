using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private bool hasEndVerse; 
    public Reference(string Book, int Chapter, int Verse){
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _endVerse = 0;
        hasEndVerse = false;
    }
    public Reference(string Book, int Chapter, int Verse, int endVerse){
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _endVerse = endVerse;
        hasEndVerse = true;
    }
    public string ReturnReference(){
        string fullReference;
        if (hasEndVerse == true){
            fullReference = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        else{
            fullReference = $"{_book} {_chapter}:{_verse} ";
        }

        return fullReference;

    }
}