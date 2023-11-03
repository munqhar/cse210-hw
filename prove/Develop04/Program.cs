using System;

class Program
{
    static void Main(string[] args)
    {   string _numberMenu;
        do
         { 
             Console.Write("Menu Options:\n1. Start Breathing Activity \n2. Start Reflecting Activity \n3. Start Listing Activity \n4. Quit\n");
             Console.Write("Select a choice from the menu: ");
              _numberMenu = Console.ReadLine();
             switch (_numberMenu)          
             {
              case "1":
              Breathing Breath = new Breathing();
              Breath.DisplayTheStartingMessage();        
              Console.WriteLine("");
              Breath.RunBreathingActivity();         
              Breath.DisplayTheEndingMessage();
              Console.Clear();
              break;  

              case "2":
              Reflection reflection = new Reflection();
              reflection.DisplayTheStartingMessage(); 
              reflection.RunReflectingActivity();
              reflection.DisplayTheEndingMessage(); 
              Console.Clear();
              break;   

              case "3":
              Listing listing = new Listing();
              listing.DisplayTheStartingMessage();
              listing.RunListingActivity();
              listing.DisplayTheEndingMessage();
              Console.Clear();
              break;
              
             }
         }while (_numberMenu != "4");
    }
}