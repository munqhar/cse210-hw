using System;

class Program
{
    static void Main(string[] args)
    {
         string _theDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";              
         Breathing Breath = new Breathing("Breathing",_theDescription);
         Breath.DisplayTheStartingMessage();        
         Console.WriteLine("");
         Breath.RunBreathingActivity();         
         Breath.DisplayTheEndingMessage();


     }
}