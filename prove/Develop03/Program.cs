using System;


class Program
{
    static void Main(string[] args)
    {
      Scripture scripture = new Scripture();
      scripture.Print();
      string _response = "";
      bool r=false;
      
      while (_response != "quit" &&  r == false  ) //|| the other condition 
      {
        r=scripture.IsCompletelyHidden();
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        _response = Console.ReadLine();
        Console.Clear();
        scripture.Hidewords();
        Console.WriteLine(" ");
        scripture.GetTheRenderText();      
        

      }  
     

    } 
}
