using System.Security;

public class Activity 
{   protected string _theActivityName;
    protected string _theDescription;
    protected int _theDurationInSeconds;
    

    public void DisplayTheStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_theActivityName} Activity.\n");
        Console.WriteLine($"{_theDescription}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _theDurationInSeconds =int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        PauseShowASpinner(2);
        Console.Clear();
    }
    public void DisplayTheEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        PauseShowASpinner(3);
        Console.WriteLine($"You have completed another {_theDurationInSeconds} seconds of the {_theActivityName} Activity.");
        PauseShowASpinner(3);
    }
    public void PauseShowASpinner(int spinnerDuration)
    {  
         string [] spinners={"|", "/", "-", "\\"};        
        DateTime endTime = DateTime.Now.AddSeconds(spinnerDuration);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(spinners[i]);  
            Thread.Sleep(500);        
            Console.Write("\b \b"); // Erase the + character             
            if (i == spinners.Count()-1)
            {
                i = 0;
            }
            i++;                      
        }           
    }
    public void PauseShowACountdown(int countDownDuration)
    {
        int i ;
        for( i = countDownDuration;i>=0;i--)
        {
           Console.Write(i);           
           Thread.Sleep(1000);           
           Console.Write("\b \b"); // Erase the + character
           //Console.Write(i+1); // Replace it with the - character          
           
        }

    }
     public Activity (string name,string description)
    {
        _theActivityName = name;
        _theDescription = description;
        

    }
    

}