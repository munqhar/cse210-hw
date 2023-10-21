using System;


class Program
{
    static void Main(string[] args)
    {string _proverbs ="Trust in the Lord with all thine heart; and  lean not unto thine own understanding.  In all thy ways acknowledge him,  and he shall direct thy paths.";
      Reference reference = new Reference("Proverbs","3","5","6");//This is the reference class     
      Console.Write($"{reference.get()} ");//We get the entire reference
      Scripture scripture = new Scripture(_proverbs);//this is the scripture class
      scripture.Print();// we print the scripture              
      string _response = "";//string response with Enter      
      
      while (_response != "quit" &&  scripture.IsCompletelyHidden() == false  ) // if the user types quit or is completely hidden the program stops
      {
        
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        _response = Console.ReadLine(); 
        Console.Clear();
        Console.Write($"{reference.get()} ");//the reference one more time
        scripture.Hidewords();//this is encharged to hide three words        
        scripture.GetTheRenderText(); // get the render text     
        

      }  
     

    } 
}
