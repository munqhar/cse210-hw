using System.Dynamic;

public class Word {
    private string _word;
    private int _visibility = 0; //i need to shange this, we are not supposed to use public attributtes,
                                // i must make a method that says is hidden or not

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
    public string IsHidden() 
    {
        if (_visibility == 1)
        {
            return "Yes";

        }
        else
         {
            return "No";
         }

    }
    public Word(string word)
    {
        _word = word;
    }   
 

}