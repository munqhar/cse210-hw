using System;

class Program
{
    static void Main(string[] args)
    {
       static void DisplayWelcome()
       {
        Console.WriteLine("Welcome to the Program!");


       }
       static string PromptUserName()
       {
        Console.Write("Please Enter your name: ");
        string a= Console.ReadLine();
        return a;

       }
       static double SquareNumber (int n)
       {
        double square = Math.Sqrt(n);
        return square;

       }
       static void DisplayResult (string userName, int squareNumber)
       { 
        Console.WriteLine($"the user name is {userName}");
        Console.WriteLine($"the square number is {squareNumber}");

       }
       DisplayWelcome();
       string userName=PromptUserName();
       Console.Write("Digit a number ");
        string nstring = Console.ReadLine();
        int n = int.Parse(nstring);
        DisplayResult(userName,n); 


    }
}