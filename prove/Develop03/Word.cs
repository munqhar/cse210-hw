using System.Dynamic;

public class Word {
    private string _word;
    public int _visibility = 0;

    public void Hide()
    {
        int _wordLength = _word.Length;
        string line="_";
        _word = string.Concat(Enumerable.Repeat(line, _wordLength));//repeat the lines in the same amount of letters of the word        
       _visibility = 1;
    }
    public void Show()
    {
        Console.Write(_word);
        

    }
    public Word(string word)
    {
        _word = word;
    }   
 

}