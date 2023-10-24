using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class Word
{
    bool isHidden;
    string _word;
    public Word(string Word){
        isHidden = false;
        _word = Word;
    }
    public void Hide(){
        _word = new string('_', _word.Length);
        isHidden = true;
    }
    public bool CheckIfHidden(){
        return isHidden;
    }
    public string ReturnText(){
        return _word;
    }
}