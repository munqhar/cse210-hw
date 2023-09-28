using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company ="Oso tedy";
        job1._jobTitle = "salesman";
        job1._startYear = 2002;
        job1._endYear = 2003;
        job1.Display();
        job1.DisplayJobDetails();
        
        Job job2 = new Job();
        job2._company ="Coca-Cola";
        job2._jobTitle = "Business administrator";
        job2._startYear = 2012;
        job2._endYear = 2025;
        job2.Display();
        job2.DisplayJobDetails();
        Resume _resume = new Resume();  
        _resume._name = "Allison Rose";      
        _resume._jobs.Add(job1);
        _resume._jobs.Add(job2);
        _resume.Display();
        
    }
}