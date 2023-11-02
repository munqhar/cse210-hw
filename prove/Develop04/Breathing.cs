public class Breathing : Activity
{
    public void RunBreathingActivity()
    {
       
        DateTime endTime = DateTime.Now.AddSeconds(_theDurationInSeconds);
        int i=2;
        while(DateTime.Now < endTime)
        { 
          Console.Write("\n\nBreathe in...");
          PauseShowACountdown(i);
          Console.Write("\nNow breathe out...");
          PauseShowACountdown(i+2);
          i++;
          if(i>=4)
          {
            i=4;
          }

        }
    }
     public Breathing (string name,string description) : base(name, description)
    {
         _theActivityName = name;
        _theDescription = description;
        
    } 
    

}