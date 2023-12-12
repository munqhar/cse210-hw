using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("RECEPTION");
       Address address = new Address("456 White Finch St.","Cecelia Havens","North Augusta","USA");
       Receptions receptions = new Receptions("wedding","we will have a small meeting to attend our relatives","3-12-2023","4:00pm",address,"hernanortega1994@gmail.com");
       receptions.ShortDescription();
       receptions.StandardDetails();
       receptions.FullDetails();

       //-----------------Lecture
       Console.WriteLine("LECTURE");
       Lectures lecture = new Lectures("wedding","we will have a small meeting to attend our relatives","3-12-2023","4:00pm",address,"Hernan Ortega",35);
       lecture.ShortDescription();
       lecture.StandardDetails();
       lecture.FullDetails();

       //--------------Outdoor Gatherings
        Console.WriteLine("OUTDOOR GATHERINGS");
       OutdoorGatherings outdoorGathering = new OutdoorGatherings("wedding","we will have a small meeting to attend our relatives","3-12-2023","4:00pm",address,"HOT");
       outdoorGathering.ShortDescription();
       outdoorGathering.StandardDetails();
       outdoorGathering.FullDetails();
    }
}