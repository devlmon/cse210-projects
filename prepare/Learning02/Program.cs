using System;

class Program
{
    static void Main(string[] args)
    {
        //First job instance
        Job job1        = new Job();
        job1._company   = "Perfect Company";
        job1._jobTitle  = "Programmer";
        job1._startYear = "2001";
        job1._endYear   = "2023";

        //Second job instance
        Job job2        = new Job();
        job2._company   = "Super Awesome Company";
        job2._jobTitle  = "Writter";
        job2._startYear = "2001";
        job2._endYear   = "2023";

        //My resume instance
        Resume myresume = new Resume();
        myresume._name  = "Luis Montenegro";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        //Output
        myresume.Display();
    }
}