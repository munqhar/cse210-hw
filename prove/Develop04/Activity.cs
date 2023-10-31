using System.Security;

public class Activity 
{   protected string _theActivityName;
    protected string _theDescription;
    protected int _theDurationInSeconds;

    public void DisplayTheStartingMessage()
    {
        Console.WriteLine("Welcome to the <<Name_Activity>>.\n");
        Console.Write("This activity will help you relax by walking your through breathing in and out slowly.");
        Console.WriteLine(" Clear your mind and focus on your breathing.\n");
        Console.Write("How long, in seconds, would you like for your session?");
        _theDurationInSeconds =int.Parse(Console.ReadLine());
    }
    public void DisplayTheEndingMessage()
    {
        Console.WriteLine("Well done!!\n");
        Console.WriteLine("You have completed another <<duration>> seconds of the breathing activity");
    }
    public void PauseShowASpinner()
    {  
         string [] spinners={"|", "/", "-", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(spinners[i]);  
            Thread.Sleep(250);        
            Console.Write("\b \b"); // Erase the + character             
            if (i == spinners.Count()-1)
            {
                i = 0;
            }
            i++;                      
        }           
    }
    public void PauseShowACountdown()
    {
        for(int i =0;i<=9;i++)
        {
           Console.Write(i);           
           Thread.Sleep(1000);           
           Console.Write("\b \b"); // Erase the + character
           //Console.Write(i+1); // Replace it with the - character          
           
        }

    }

}