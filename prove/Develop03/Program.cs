using System;


class Program
{
    static void Main(string[] args)
    { 
      Reference reference = new Reference();//This is the reference class     
      Console.Write($"{reference.get()} ");//We get the entire reference
      Scripture scripture = new Scripture();//this is the scripture class
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
