using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    { int number=1;
     int sum = 0;
     float average = 0;
     int max=0;
     int min;     
     List<int> numbers;
     numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            if(number != 0)
            {
            numbers.Add(number);
            }
            
        }

        min=numbers[0];
        for (int i = 0; i < numbers.Count; i++)
          {
            sum =numbers[i]+sum; 
            if (numbers[i] > max)
            {
                max = numbers[i];
            } 
            if (numbers[i] < min && numbers[i]>0)
            {
               min=numbers[i];
            } 
            else if (min<0)
            {
                min = numbers[i+1];
            }           
          

          }
                     
          average=sum/(numbers.Count-1);
          Console.WriteLine($"The sum is {sum}, the average is {average}, the max is {max},");
          if (min < 0)
          {
            Console.Write("there is no smallest positive number");
          }
          else
          {
            Console.Write($"the smallest number is {min}");
          }
       numbers.Sort();             
       for (int i =0; i<numbers.Count;i++)
       {
         Console.WriteLine(numbers[i]);
       }

              
          
         
    }
}