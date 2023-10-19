using System.Security.Cryptography.X509Certificates;

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
      
      for ( int i=0; i<_words.Count;i++)
      {
        if (i<= 2)
         {
          _words[i].Hide();
          }
          
      
      }


    }
    public void GetTheRenderText()
    {
       for ( int i=0; i<_words.Count;i++)
      {
        if (i<= 2)
         {
          _words[i].Hide();
          }
          else
          _words[i].Show();
          
      
      }
    }

    
}