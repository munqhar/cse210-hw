using System;

class Program
{
    static void Main(string[] args)
    {
        
         Entry FirstEntry = new Entry();
         PromptGenerator PromptGenerator = new PromptGenerator();
         FirstEntry.Prompt=PromptGenerator.CreatesPrompt();
         string _numberMenu=" ";
         Journal journal = new Journal();
         int i=0;
       do
       {
         Console.Write("Welcome to the Journal Program! \nPlease select on of the following choices \n1.Write \n2.Display \n3.Load\n4.Save\n" );
         Console.WriteLine("5.Quit\nWhat would you like to do? ");
          _numberMenu = Console.ReadLine();
          journal._entries[i] = FirstEntry ;
         switch (_numberMenu)
         {
             case "1":           
             
             FirstEntry._response=FirstEntry.showpromptAndSaveEntry();
             DateTime theCurrentTime = DateTime.Now;
             FirstEntry._datetext = theCurrentTime.ToShortDateString();
             
             
             break;
 
             case "2":
              journal.Display();
             break;
             case "3":
 
             case "4":
 
             case "5":
             break;
            
 
 
          }
          
          i=i+1;
           
       }while (_numberMenu != "5");

    }
}