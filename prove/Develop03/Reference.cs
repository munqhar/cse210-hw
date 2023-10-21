public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
    private string A;
    //private List<string> Referencias = new List<string>;

    public Reference()
    {
        _book="John";
        _chapter = "3";
        _startVerse = "16";
        _endVerse = "16"; 

    }
    public Reference (string book, string chapter, string startverse,string endverse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        _endVerse = endverse;
    }
    public string get()
    {
         if (_startVerse == _endVerse)
         {
             A= ($"{_book} {_chapter}: {_startVerse} ");

         }
         else
         {
             A = ($"{_book} {_chapter}: {_startVerse}-{_endVerse} ");
         }        
        
        return A;

    }



}