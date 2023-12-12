public class Video
{
    public string _tittle;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
  
    public  Video(string tittle, string author, int length,List<Comment> comments )
    {
        _author = author;
        _length = length;
        _tittle = tittle;
        _comments = comments;
    }
      public int NumberOfComments()
    {
        return _comments.Count;
    }
    public void display()
    {
        Console.Write($"Tittle: {_tittle}, Author: {_author}, Length: {_length} seconds, ");
    }
}