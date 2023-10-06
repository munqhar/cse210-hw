public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void Display()
    {
        Console.WriteLine("This is the entire journal:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }



}