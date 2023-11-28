using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> Videos = new List<Video>();
        List<Comment> _comments1 = new List<Comment>();
        //Video 1
        string tittle = "Somewhere over the Rainbow";
        string author = "Israel \"IZ\" Kamakawiwo'ole ";
        int length = 222;
        

        //comment 1
        string nameOfThePerson = "@benkyker6923";
        string textComment = "This song deserves every single one of those 1 billion views";  
        Comment comment1 = new Comment(nameOfThePerson,textComment);        
        _comments1.Add(comment1);
        //Comment2
        nameOfThePerson = "@AlbanianWarrior007";
        textComment = "After 13 years of IZ this song still remarkable and has such beautiful vibes and melodious voice ⭐️🔥 Everyone in this world is loving you IZ. Thank you for this song buddy!";
        Comment comment2 = new Comment(nameOfThePerson,textComment);
        _comments1.Add(comment2);
        //Comment 3
        nameOfThePerson = "@kevinwheesysouthward9295";
        textComment = "I have no idea why but this version of this song makes me cry like a baby. It absolutely kills me. His voice was gorgeous";
        Comment comment3 = new Comment(nameOfThePerson,textComment);
        _comments1.Add(comment3);
        Video video1 = new Video(tittle,author,length,_comments1);                
        Videos.Add(video1);
        //-----------------------------------------------------------------------------
        //video 2
         List<Comment> _comments2 = new List<Comment>();
        tittle = "Livin' On A Prayer";
        author = "Bon Jovi ";
        length = 248;
        Video video2 = new Video(tittle,author,length,_comments2); 
        //comment1
        nameOfThePerson = "@Jac1324";
        textComment = "80's music will never get old";
        Comment comment21 = new Comment(nameOfThePerson,textComment);        
        _comments2.Add(comment21);

        //comment2
        nameOfThePerson = "@caseyco21707";
        textComment = "If you're not born in this era but love this kind of music, welcome to the club.";
        Comment comment22 = new Comment(nameOfThePerson,textComment);        
        _comments2.Add(comment22);

        //comment3
        nameOfThePerson = "@chickenporkmeatfishteriyaki";
        textComment = "2023 and it's still a song that makes me feel good in the shower, in the car, at the gym, at the bar, wherever";
        Comment comment23 = new Comment(nameOfThePerson,textComment);        
        _comments2.Add(comment23);
        Videos.Add(video2);

        //video3
        List<Comment> _comments3 = new List<Comment>();
        tittle = "Every Breath You Take";
        author = "The Police ";
        length = 228;
        Video video3 = new Video(tittle,author,length,_comments3);
        //comment1
        nameOfThePerson = "@jasoncummings7052";
        textComment = "The 80's was an absolute golden era of music.";
        Comment comment31 = new Comment(nameOfThePerson,textComment);        
        _comments3.Add(comment31);

        //comment2
        nameOfThePerson = "@sammyt3514";
        textComment = "They don't make music like this anymore; none of the popular songs now will be as fresh, modern and absolutely a pleasure to listen to like this song is 40 years from now!";
        Comment comment32 = new Comment(nameOfThePerson,textComment);        
        _comments3.Add(comment32);

        //comment3
        nameOfThePerson = "@8bert9";
        textComment = "The emotional power of this classic is not only in its lyrics but also in the captivating melodies and rhythms.";
        Comment comment33 = new Comment(nameOfThePerson,textComment);        
        _comments3.Add(comment33);
        Videos.Add(video3);
        foreach(Video videos in Videos)
        {
            videos.display();
            Console.Write($"Number of Comments: {videos.NumberOfComments()}\n");

        }
        


    }
}