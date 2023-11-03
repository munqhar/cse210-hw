using System;

class Program
{
    static void Main(string[] args)
    {
        do
         { 
            Console.Write("Welcome to the Journal Program! \nPlease select on of the following choices \n1.Write \n2.Display \n3.Load\n4.Save\n" );
            Console.WriteLine("5.Quit\nWhat would you like to do? ");
            _numberMenu = Console.ReadLine();
            switch (_numberMenu)          
             Breathing Breath = new Breathing();
             Breath.DisplayTheStartingMessage();        
             Console.WriteLine("");
             Breath.RunBreathingActivity();         
             Breath.DisplayTheEndingMessage();  
         
             Reflection reflection = new Reflection();
             reflection.DisplayTheStartingMessage(); 
             reflection.RunReflectingActivity();
             reflection.DisplayTheEndingMessage();      
       
             Listing listing = new Listing();
             listing.DisplayTheStartingMessage();
             listing.RunListingActivity();
             listing.DisplayTheEndingMessage();
         }
    }
}