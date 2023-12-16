using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
         string _numberMenu;
         //List<string> ListGoals = new List<string>();
         List<Goal> goals = new List<Goal>();
         List<string> GoalType = new List<string>();
         int cont = 0;
         string name ="";
         string description ="";
         int points = 0;
         string goalType ="";
         int timesToGetBonus= 0;
         int bonus = 0;
         int totalPoints = 0;
         int tries = 0;
         //SimpleGoal simpleGoal = new SimpleGoal(name, description, points,goalType);
         //EternalGoal eternalGoal = new EternalGoal(name, description, points,goalType); 
         //CheckListGoal checkListGoal = new CheckListGoal(name, description, points, goalType, timesToGetBonus, bonus, tries);               

        do
         { 
             Console.WriteLine($"You have {totalPoints}. \n");
             Console.Write("Menu Options:\n 1. Create a New Goal \n 2. List Goals \n 3. Save  Goals \n 4. Load Goals\n 5. Record Event\n 6. Negative Goals\n 7. Quit\n");
             Console.Write("Select a choice from the menu: ");
              _numberMenu = Console.ReadLine();
             switch (_numberMenu) 
             {
             case "1":
             Console.WriteLine("The types of Goals are:");
             Console.Write(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n ");
             Console.Write("Which type of goal would you like to create? ");
             string _goalType = Console.ReadLine();
             if(_goalType == "1")
             {
                goalType = "Simple Goal";
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());                
                cont++;
                //ListGoals.Add($" {name}, {description}");
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points,goalType);
                goals.Add(simpleGoal);
                //GoalType.Add("Simple Goal");
             }
             else 
                if(_goalType == "2")
                {
                    goalType = "Eternal Goal";
                    Console.Write("What is the name of your goal? ");
                     name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                     description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                     points = int.Parse(Console.ReadLine());                
                    cont++;
                    EternalGoal eternalGoal = new EternalGoal(name, description, points,goalType);
                    goals.Add(eternalGoal);
                    //ListGoals.Add($"{name}, {description}");                    
                    GoalType.Add("Eternal Goal");
                }
                else
                {
                    if(_goalType == "3")
                    {
                        goalType = "CheckList Goal";
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    points = int.Parse(Console.ReadLine()); 
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    timesToGetBonus= int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times ");
                    bonus = int.Parse(Console.ReadLine());
                    CheckListGoal checkListGoal = new CheckListGoal(name, description, points, goalType, timesToGetBonus, bonus, tries);
                    goals.Add(checkListGoal);
                    cont++;
                    //ListGoals.Add($"{name}, {description}");
                    //GoalType.Add("CheckList Goal");

                    }
                }
             break ;
             case "2":
             for(int i = 0; i < goals.Count; i++)
             {
                if(goals[i].IsComplete() == true)
                {
                    Console.Write($"{i+1}. [X] ");
                    goals[i].ShowListGoal();
                    
                }
                else
                {
                    Console.Write($"{i+1}. [] ");
                    goals[i].ShowListGoal();
                    
                }
             }
             //simpleGoal.ShowListGoal();
             break;
             case "3":
             //Creating the file
             using (StreamWriter outputFile = new StreamWriter("goal.txt"))
                 
             {
                for(int i = 0; i < goals.Count; i++)
                {
                  if (goals[i].GetType() == "CheckList Goal")
                  {
                      outputFile.WriteLine($"{goals[i].CreateFile()},{timesToGetBonus},{bonus}");
                  }   
                  else
                  {       
                      outputFile.WriteLine($"{goals[i].CreateFile()}");     
                  }
                }             
             } 

             break;
             case "4":
             string[] lines = System.IO.File.ReadAllLines("goal.txt");
             foreach (string line in lines)
             {  char[] delimiterChars = { ',',':' };            
                 string[] parts = line.Split(delimiterChars);
                 goalType = parts[0];             
                 name = parts[1];             
                 description = parts[2];  
                 points = int.Parse(parts[3]);
                 if(parts[0]=="Simple Goal")
                  {
                      SimpleGoal simpleGoal = new SimpleGoal(name, description, points,goalType);
                      goals.Add(simpleGoal);
                  }                 
                else
                  {if (parts[0]=="Eternal Goal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, description, points,goalType);
                        goals.Add(eternalGoal);
                    }
                    else
                    {
                        if(parts[0]=="CheckList Goal") 
                         {
                           timesToGetBonus = int.Parse(parts[4]);
                           bonus = int.Parse(parts[5]);
                           CheckListGoal checkListGoal = new CheckListGoal(name, description, points, goalType, timesToGetBonus, bonus, tries);
                           //CheckListGoal checkListGoal1 = new CheckListGoal(name, description, points,goalType,timesToGetBonus,bonus,tries);
                           goals.Add(checkListGoal);
                         }
                    }
                    
                  }        
              
             } 
             
             break;
             case "5":
             Console.WriteLine("The goals are");
                for(int i = 0;i<goals.Count();i++)
                 {
                    Console.Write($" {i+1}.{goals[i].getname()}\n");
                 }
                 Console.Write("Which goal did you accomplish? ");
                 int answer = int.Parse(Console.ReadLine());
                 if(goals[answer-1].GetType()== "CheckList Goal")
                 {                    
                    goals[answer-1].RecordEvents();  
                    if(goals[answer-1].IsComplete()== true)
                    {
                        totalPoints = goals[answer-1].GetPoints()+totalPoints;                 
                    }

                 }
                 else
                 {
                    goals[answer-1].RecordEvents();
                    totalPoints = goals[answer-1].GetPoints()+totalPoints;
                 }

                 //goals[answer-1].

             break;
             case "6":
             Console.WriteLine("Negative goals, just as there are good goals which you can get points, also there are negative goals which you can lost points ");
             Console.Write("The negative goals are:\n 1. Getting Distracted by Everyday Things\n 2. Under-Sleeping or no sleep at all\n 3. Allowing Negative Thoughts and Limiting Ideas in Your Life ");
             
             string _answer = (Console.ReadLine());
             if(_answer == "1")
             {
                Console.WriteLine("Control distractions by putting together a clean and minimal work environment.");
                Console.Write("What is the amount of points associated with this goal? ");
                int _negativePoints = int.Parse(Console.ReadLine());
                Console.WriteLine($"You have lost {_negativePoints} points.");
                totalPoints = totalPoints - _negativePoints;
             }
             else
             {
                if(_answer == "2")
                {
                Console.WriteLine("People who sleep at least 7.5 hours each night report feeling much happier and more productive than those who sleep less than six hours per night.");
                Console.Write("What is the amount of points associated with this goal? ");
                int _negativePoints = int.Parse(Console.ReadLine());
                Console.WriteLine($"You have lost {_negativePoints} points.");
                totalPoints = totalPoints - _negativePoints;
                }
                else
                {
                    if(_answer == "3")
                    {
                        Console.WriteLine("Limiting beliefs limit your potential. Start focusing on the things you can do, the activities you’re good at.");
                        Console.WriteLine("A conscious shift towards positive thinking will also impact your actions and your self-image. Once the confidence gets established, you’ll be unstoppable.");
                        Console.Write("What is the amount of points associated with this goal? ");
                        int _negativePoints = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You have lost {_negativePoints} points.");
                        totalPoints = totalPoints - _negativePoints;
                    }
                    
                }
             }

             break;
             }
         }while (_numberMenu != "7");
        
    }
}