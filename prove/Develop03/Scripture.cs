using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
public class Scripture 
{
    private List<Word> _words = new List<Word>();
    private string _scripture;
    private Reference _reference;
    public int i ;
    public Scripture ()
    {
      _scripture = "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
      string[] x = _scripture.Split(" ");
      foreach (string i in x)
       {Word _word = new Word(i);
        _words.Add(_word);
        //Console.Write($"{i} "); we use this to see how our program is doing.
       }
      
      
    }
    public void Hidewords()
    {
      Random randomGenerator = new Random();
      
      for ( int i=0; i<=2;i++)
      {
        int number = randomGenerator.Next(0, _words.Count);
        //if (_words[number]._visibility == false)
           _words[number].Hide();
        
          
      
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

    
}