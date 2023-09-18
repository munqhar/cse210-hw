using System;

class Program
{
    static void Main(string[] args)
    { string answer = "yes";
        while (answer == "yes")
        {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);  
        int count=0;                             // generating the random number for the magic number
        /* Console.WriteLine("What is the magic number?");
        string answer =  Console.ReadLine();
        int number = int.Parse(answer); */
        int guess = 0;
        
        
        
        do
        {
         Console.WriteLine("What is your guess?");
         string guessString = Console.ReadLine();                               //saving the guess number we use a do-while loop
         guess= int.Parse(guessString);
         if (guess < number)
         {
            Console.WriteLine("higher");
         }
         else if (guess > number)
         {
            Console.WriteLine("lower");
         }
         else 
         {
               Console.WriteLine("you guess the number");
         }
         count++;
         
        }
        while(guess != number);
        Console.WriteLine($"the number of tries were {count}");
        Console.WriteLine("Do you want to continue playing yes or not ?");
        answer = Console.ReadLine();
        }
    }
}