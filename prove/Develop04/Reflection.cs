public class Reflection: Activity
{
    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();
    protected int _randomnumber;
    public string GetPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        return _prompts[number];       
    }
    public string GetQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _questions.Count);
        return _questions[number];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetPrompt()} --- \n");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetQuestion()}");
    }
    public void RunReflectingActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in:");
        PauseShowACountdown(9);
        DateTime endTime = DateTime.Now.AddSeconds(_theDurationInSeconds);
        while(DateTime.Now < endTime)
        { 
            DisplayQuestion();
            PauseShowASpinner(10);
        }

    }
    public Reflection(string name, string description) : base(name,description)
    {
        _theActivityName = name;
        _theDescription = description;

    }
}