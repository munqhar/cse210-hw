using System;

class Program
{
    static void Main(string[] args)
    {    Console.WriteLine("Hello Learning03 World!");
        Fraction Fraction = new Fraction (5,2);
           Console.WriteLine(Fraction.GetFractionString());
       Console.WriteLine(Fraction.GetDecimalValue());
       
    }
}