using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling("11/12/2023",30,15);
        
        Running running = new Running("11/12/2023",30,25);        
        
        Swiming swiming = new Swiming("11/12/2023",30,15);
        
        List<Activity> Activities = new List<Activity>();
        Activities.Add(cycling);
        Activities.Add(running);
        Activities.Add(swiming);
        foreach(Activity activity in Activities)
        {
            activity.GetSummary();
        }

    }
}