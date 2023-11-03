using System;

class Program
{
    static void Main(string[] args)
    {
         /* string _theDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";              
          Breathing Breath = new Breathing("Breathing",_theDescription);
         Breath.DisplayTheStartingMessage();        
         Console.WriteLine("");
         Breath.RunBreathingActivity();         
         Breath.DisplayTheEndingMessage();  */
         string _theDescription ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
         Reflection reflection = new Reflection("Reflection",_theDescription);
         reflection.DisplayTheStartingMessage(); 
         reflection.RunReflectingActivity();
         reflection.DisplayTheEndingMessage(); 


     }
}