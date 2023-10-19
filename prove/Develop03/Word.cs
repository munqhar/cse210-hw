using System.Dynamic;

public class Word {
    private string _word;
    public bool _visibility;

    public void Hide()
    {
        int _wordLength = _word.Length;
        string line="_";
        _word = string.Concat(Enumerable.Repeat(line, _wordLength));
        //int i = 0;

        /* while (i<=_wordLength)
        {
            _word = line;
            i++;
        }    */     
       _visibility = false;
    }
    public void Show()
    {
        Console.Write(_word);
        _visibility=true;

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