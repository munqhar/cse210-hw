using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    public  DateAndTime _day;

    public string CreatesPrompt()
    {
        List<string> Prompts = new List<string>();
        Prompts.Add("What do you want to be when you grow up? Why?");
        Prompts.Add("What are five things you would like to do before you are 20 years old?");
        Prompts.Add("What is your dream job? Describe a typical work day at this job.");
        Prompts.Add("What do you think your life will be like when you are 30 years old?");
        Prompts.Add("What are the three most important jobs in the world? Why are these three jobs so important?");
        Prompts.Add("Would you want to be the president? Why or why not?");
        Prompts.Add("Would you rather be a famous writer, a rock star, or a doctor who finds a cure for cancer? Why?");
        Prompts.Add("What are the most important qualities in a friend? Are you a good friend? Why or why not?");
        Prompts.Add("Is it ever okay to lie? Why do you think so?");
        Prompts.Add("What are three things that every parent should do? Why are these things important?");
        Prompts.Add("It has been said that money can't buy happiness. Do you agree or disagree? Why?");
        Prompts.Add("Would you rather be beautiful, smart, or athletic? Why?");
        Prompts.Add("Describe a real made-up dream or nightmare.");
        Prompts.Add("Write about your favorite childhood toy.");
        Prompts.Add("Write out the best or the worst day of your life.");
        Prompts.Add("Finish this thought: if I could change one thing about myself (if you can't think of anything, you might want to consider telling how you got to be perfect!)");
        Prompts.Add("If and when I raise children, I'll never...");
        Prompts.Add("I have never been more frightened than when...");
        Prompts.Add("Persuade a friend to give up drugs.");
        Prompts.Add("Five years from now, I will be...");
        Prompts.Add("Write about a day you'd like to forget.");
        Prompts.Add("Invent and describe a new food.");
        Prompts.Add("Describe an event that changed your life forever, or make up and describe an event that would change your life forever.");
        Prompts.Add("Describe someone who is a hero to you and explain why.");
        Prompts.Add("Write about a time in your life when you struggled with a choice and made the right one.");
        Prompts.Add("Imagine yourself in a different century and describe an average day in your life.");
        Prompts.Add("Which character from a book would you most like to meet and why?");
        Prompts.Add("Three goals I have set for myself are...");
        Prompts.Add("List the top 5 people you admire, and why.");
        Prompts.Add("Who is your favorite person in the world and why?");
        Prompts.Add("What is your favorite song/musical piece and why?");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 30);
        return Prompts[number];
    
    }



}