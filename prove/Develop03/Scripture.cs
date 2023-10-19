using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
public class Scripture 
{
    private List<Word> _words = new List<Word>();
    private string _scripture;
    private Reference _reference;
    private int j=0 ;
    private int k=0;
    private bool _hidden;
  
    public Scripture ()
    {
      _scripture = "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
      string[] x = _scripture.Split(" ");
      foreach (string i in x)
       {Word _word = new Word(i);
        _words.Add(_word);
        //Console.Write($"{i} "); //we use this to see how our program is doing.
       }
      
      
    }
    public void Hidewords()
    {Random randomGenerator = new Random();
      int number = randomGenerator.Next(0, _words.Count);
      for ( int i=0; i<=2;i++)
      {               
       if (_words[number]._visibility == 1)
        {
          while (j == 0 && k<_words.Count)
          {
              number = randomGenerator.Next(0, _words.Count);
              if (_words[number]._visibility == 0)
               {
                 _words[number].Hide();
                 j=1;
                 
               }            
                        
          }    
         
        }
        else 
        {  
         _words[number].Hide();         
      
        }
        number = randomGenerator.Next(0, _words.Count);
        k++;
        j=0;
      }
    }
    public void GetTheRenderText()
    {
       foreach (Word word in _words )
      {
        word.Show();
        Console.Write(" ");     
      }
    }
  public void Print()
      {
        Console.Write(_scripture);
      }
      public bool IsCompletelyHidden()
      {
        if (k ==_words.Count)
        {
          _hidden = true;
          
        }
        else
        {
          _hidden = false;
        }
        return _hidden;
      }
    

    
}