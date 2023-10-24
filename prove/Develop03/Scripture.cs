using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

class Scripture
{
    private List<Word> listWords = new List<Word>();
    public Reference reference;

    public Scripture(string Reference, string Verse)
    {
        //split the reference into its part and send it to the reference class to make the reference.
        string[] splitReference = Reference.Split(new char[] {':', ' ', '-'}, StringSplitOptions.RemoveEmptyEntries);
        if (splitReference.Length > 3){
            reference = new Reference(splitReference[0], int.Parse(splitReference[1]), int.Parse(splitReference[2]), int.Parse(splitReference[3]));
        }
        if (splitReference.Length == 3){
            
            reference = new Reference(splitReference[0], int.Parse(splitReference[1]), int.Parse(splitReference[2]));
        }

        //split the verse into indivdiual words
        string[] splitVerse = Verse.Split(new char[] {':', ' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitVerse)
        {
            listWords.Add(new Word(word));
        }
    }
    public void DisplayScripture()
    {
        List<string> verse = new List<string>();
        foreach (var word in listWords)
        {
            verse.Add(word.ReturnText());
        }
        string Verse = string.Join(" ", verse);
        Console.WriteLine($"{reference.ReturnReference()}{Verse}"); 
    }
    public void HideRandomWords(int selectedNumber)
    {
        if (NumberVisableWords() < 3)
        {
            selectedNumber = NumberVisableWords();
        }
        Random rnd = new Random();
        Word GenerateNewWord()
        {
           int rndIndex = rnd.Next(listWords.Count());
           Word word = listWords[rndIndex];
           return word;
        }
        for (int i = 0; i < selectedNumber; i++)
        {
            Word word = GenerateNewWord();
            while (word.CheckIfHidden() == true)
            {
                word = GenerateNewWord();
            }
            word.Hide();
        }
    }
    public bool CheckforEnd()
    {
        int count = 0;
        foreach (Word word in listWords)
        {
            if (word.CheckIfHidden() == false)
            {
                count += 1;
            }
        }
        if (count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private int NumberVisableWords()
    {
        int count = 0;
        foreach (Word word in listWords)
        {
            if (word.CheckIfHidden() == false)
            {
                count += 1;
            }
        }
        return count;
        
    }
}
