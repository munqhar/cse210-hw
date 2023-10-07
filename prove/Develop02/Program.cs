using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
          
         string _numberMenu=" ";
         Journal journal = new Journal();
         int i=0;
         string _fileName;
       do
       {
         Console.Write("Welcome to the Journal Program! \nPlease select on of the following choices \n1.Write \n2.Display \n3.Load\n4.Save\n" );
         Console.WriteLine("5.Quit\nWhat would you like to do? ");
          _numberMenu = Console.ReadLine();
          //journal._entries[i] = FirstEntry ;
         switch (_numberMenu)
         {
             case "1":           
             Entry FirstEntry = new Entry(); //FirstEntry is encharged to show and save the prompt, the response and the date. 
             PromptGenerator PromptGenerator = new PromptGenerator();
             FirstEntry.Prompt=PromptGenerator.CreatesPrompt();
             FirstEntry._response=FirstEntry.showpromptAndSaveEntry();
             DateTime theCurrentTime = DateTime.Now;
             FirstEntry._datetext = theCurrentTime.ToShortDateString();
             journal._entries.Add(FirstEntry);              
             
             break;
 
             case "2":
              journal.Display();
             break;
             case "3":
                  
             Console.WriteLine("What is the filename?");
             _fileName = Console.ReadLine();
             string[] lines = System.IO.File.ReadAllLines(_fileName);
             foreach (string line in lines)
             {Entry SecondEntry = new Entry();  // the second entry is encharged to load the information in a file 
              string[] parts = line.Split(",,");
                SecondEntry.Prompt = parts[0];             
                SecondEntry._response = parts[1];             
                SecondEntry._datetext = parts[2];   
                journal._entries.Add(SecondEntry);           
              
             }
             break;
 
             case "4":
             Console.WriteLine("What is the filename?");
             _fileName = Console.ReadLine();
             using (StreamWriter outputFile = new StreamWriter(_fileName))
             {foreach ( Entry entry in journal._entries)
              {          
               outputFile.WriteLine(entry.Eachentries());          
              }             
             }
             break;
 
             case "5":
             break;
            
 
 
          }
          
          i=i+1;
           
       }while (_numberMenu != "5");

    }
}