public class Resume
  {         
           public string _name ="";
           public List<Job> _jobs = new List<Job>();
           
           
            public void Display()
         {
            
            Console.WriteLine($"{_name}");
            Console.WriteLine($"jobs: ");
             foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
        
         }
      



}