using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
public class Scripture 
{
    private List<Word> _words = new List<Word>();
    private string _scripture;    
    private int j=0 ;
    private int k=0;
    private bool _hidden;
  
    public Scripture ()
    {
      _scripture = "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
      string[] x = _scripture.Split(" ");//we split every word in a string vector
      foreach (string i in x)
       {Word _word = new Word(i);// we asing every word the class Word
        _words.Add(_word);//we add every class Word to a list of Word type
        //Console.Write($"{i} "); //we use this to see how our program is doing.
       }
      
      
    }
    public Scripture (string scripture)
    {
      _scripture = scripture;
      string[] x = _scripture.Split(" ");//we split every word in a string vector
      foreach (string i in x)
       {Word _word = new Word(i);// we asing every word the class Word
        _words.Add(_word);//we add every class Word to a list of Word type
        //Console.Write($"{i} "); //we use this to see how our program is doing.
       }

    }
    public void Hidewords()
    {Random randomGenerator = new Random();
      int number = randomGenerator.Next(0, _words.Count);//_words count is the length of the list, how many elements has
      for ( int i=0; i<=2;i++) // we hide three words
      {               
       if (_words[number].IsHidden() == "Yes")//if the visibility is 1 then it's hidden and if it's 0 is shown
        {
          while (j == 0 && k<_words.Count)//if it's hidden, so we look other which is shown in order to hide it, 
          {                               //if we find one we change the value of j, we look in the entire list.
              number = randomGenerator.Next(0, _words.Count);
              if (_words[number].IsHidden() == "No")
               {
                 _words[number].Hide();
                 j=1;
                 
               }            
                        
          }    
         
        }
        else 
        {  
         _words[number].Hide();   // if its shown we hide that word      
      
        }
        number = randomGenerator.Next(0, _words.Count);//we generate other number because now the word in both cases is hidden
        k++;// we count to recognize when we have iterated the entire list.
        j=0;//we set j=0 here because we do not know if we have finished the for loop
      }
    }
    public void GetTheRenderText()
    {
       foreach (Word word in _words )
      {
        
        word.Show();//this is a method to help us to show every word 
        Console.Write(" "); //blank space to see the words like a paragraph    
      }
    }
  public void Print()
      {
        Console.Write(_scripture);//we print the scripture
      }
      public bool IsCompletelyHidden() //a method to know if the paragraph is completely hidden
      {
        if (k ==_words.Count) //if we have iterated the enterite list so the paragraph is hidden
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