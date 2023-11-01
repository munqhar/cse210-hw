using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing Breath = new Breathing();
        //Breath.DisplayTheStartingMessage();
        Breath.DisplayTheEndingMessage();
        Console.WriteLine("");
        Breath.PauseShowACountdown(9); 

     }
}