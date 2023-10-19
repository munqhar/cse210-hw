using System.Dynamic;

public class Word {
    private string _word;
    public int _visibility = 0;

    public void Hide()
    {
        int _wordLength = _word.Length;
        string line="_";
        _word = string.Concat(Enumerable.Repeat(line, _wordLength));//repeat the lines in the same amount of letters of the word
        //int i = 0;

        /* while (i<=_wordLength)
        {
            _word = line;
            i++;
        }    */     
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
   
   /*  private string _word;
    public Word(string word)
    {
        _word = word;

    }
     public  bool HiddenandShown (string text)
    { bool response = false;
                    
  
        char[] spearator = { ' ' }; 
  
        // using the method 
        String[] strlist = text.Split(spearator,  
           StringSplitOptions.RemoveEmptyEntries); 
  
        foreach(String s in strlist) 
        { 
            if (s == _word)
            {
                response= true;

            }
            else
            {
                 response = false;
            }
            
            
        } 
        return response;

    }  */

}