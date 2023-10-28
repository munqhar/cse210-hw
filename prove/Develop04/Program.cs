using System;

class Program
{
    static void Main(string[] args)
    {
        
    
DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(10);
int i = 0;
while(i == 0)
{ 
Thread.Sleep(2000);

DateTime currentTime = DateTime.Now;
if (currentTime < futureTime)
{
    Console.WriteLine("We have not arrived at our future time yet...");
    
}
else{
    Console.WriteLine("We have arrived");  
    break;
    }  
 }

    }
}