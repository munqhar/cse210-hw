public class Listing: Activity
{
    protected List<string> _items = new List<string>();
    protected List<string> _answersItems = new List<string>();
    protected int _randomnumber;
    private const string description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public string GetPrompt()
    {
     _items.Add("Who are people that you appreciate?");
     _items.Add("What are personal strengths of yours?");
     _items.Add("Who are people that you have helped this week?");
     _items.Add("When have you felt the Holy Ghost this month?");
     _items.Add("Who are some of your personal heroes?");
     Random randomGenerator = new Random();
     int number = randomGenerator.Next(0, _items.Count);
     return _items[number];      
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetPrompt()} --- ");
    }
    public void RunListingActivity ()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.WriteLine("You may begin in:");        
        DateTime endTime = DateTime.Now.AddSeconds(_theDurationInSeconds);
        while(DateTime.Now < endTime)
        {
             Console.Write(">");
             _answersItems.Add(Console.ReadLine());            

        }
        Console.WriteLine($"You listed {_answersItems.Count} items!");
       

    }
    public Listing(string name="Listing") : base(name, description)
    {
        _theActivityName = name;
        _theDescription = description;

    }


}