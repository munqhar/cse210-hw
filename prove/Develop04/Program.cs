using System;

class Program
{
    static void Main(string[] args)
    {
        Activity Breath = new Activity();
        //Breath.DisplayTheStartingMessage();
        Breath.DisplayTheEndingMessage();
        Console.WriteLine("");
        Breath.PauseShowACountdown(); 

     }
}