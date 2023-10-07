public class Entry 
{ public string _response;
public string _datetext;
public string Prompt;
public string  eachentries;

    public string showpromptAndSaveEntry()
    {
        Console.WriteLine(Prompt);
       string _response = Console.ReadLine();  
       return _response;
       
       

    }
    public void Display ()
    {
        Console.WriteLine($"The Prompt: {Prompt}\nThe response: {_response}\nThe date: {_datetext}");
    }
    public string Eachentries()
    {
       eachentries = ($"{Prompt},,{_response},,{_datetext}");
       return eachentries;

    }




}