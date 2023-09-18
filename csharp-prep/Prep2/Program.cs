using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentagestring = Console.ReadLine();
         int gradePercentage = int.Parse(gradePercentagestring);
         int pass = 0;
         string letter, sign=" " ;
         if (gradePercentage >= 90)
         {
          letter = "A";
         }
         else if (gradePercentage >= 80)
             { 
               letter = "B";

             }
             else if (gradePercentage >= 70)
               { letter = "C";
            
               }
               else if(gradePercentage >= 60)
                 { letter = "D";

                 }
                  else 
                  {
                  letter = "F";
                  pass = 1;
                  }

 
if  (pass == 0)
{
  Console.WriteLine("Congratulations! you pass the class ");
}     
else
{
  Console.WriteLine(" Everyone fails at some point. Plenty of other people in our class are in the same position as you, and I know that you will all get through it. ");
}     
if (gradePercentage % 10 <3 && letter != "F" )
{
   sign = "-";
}
else 
  if(gradePercentage % 10 >= 7 && letter !="A" && letter !="F")
  {
    sign="+";
  }

  Console.WriteLine($"your letter grade is {letter}{sign}");   

    }
}