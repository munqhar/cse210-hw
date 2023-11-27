using System;

class Program
{
    static void Main(string[] args)
    {
        //Video 1
        string tittle = "Somewhere over the Rainbow";
        string author = "Israel \"IZ\" Kamakawiwo'ole ";
        int length = 222;
        List<Video> Videos = new List<Video>();
        List<Comment> _comments = new List<Comment>();

        //comment 1
        string nameOfThePerson = "@benkyker6923";
        string textComment = "This song deserves every single one of those 1 billion views";  
        Comment comment1 = new Comment(nameOfThePerson,textComment);        
        _comments.Add(comment1);
        //Comment2
        nameOfThePerson = "@AlbanianWarrior007";
        textComment = "After 13 years of IZ this song still remarkable and has such beautiful vibes and melodious voice ⭐️🔥 Everyone in this world is loving you IZ. Thank you for this song buddy!";
        Comment comment2 = new Comment(nameOfThePerson,textComment);
        _comments.Add(comment2);
        //Comment 3
        nameOfThePerson = "@kevinwheesysouthward9295";
        textComment = "I have no idea why but this version of this song makes me cry like a baby. It absolutely kills me. His voice was gorgeous";
        Comment comment3 = new Comment(nameOfThePerson,textComment);
        _comments.Add(comment3);
        Video video1 = new Video(tittle,author,length,_comments);        
        Console.WriteLine(video1.NumberOfComments());
        Videos.Add(video1);
        //-----------------------------------------------------------------------------
        //video 2
         tittle = "Livin' On A Prayer";
         author = "Bon Jovi ";
         length = 248;
         nameOfThePerson = "@Jac1324";
         textComment = "80's music will never get old";
       
        


    }
}