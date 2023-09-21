using System;

class Program
{
    static void Main(string[] args)
    {
        Job job0 = new Job();
        job0._jobtitle = "Software Engineer";
        job0._company = "Microsoft";
        job0._startyear = 2019;
        job0._endyear = 2022;

        Job job1 = new Job();
        job1._jobtitle = "Manager";
        job1._company = "Apple";
        job1._startyear = 2022; 
        job1._endyear = 2023; 

        Resume myResume = new Resume();
        myResume._name = "Bryce Dana";

        myResume._jobs.Add(job0);
        myResume._jobs.Add(job1);

        myResume.Display();


    }
}


class Resume
{

}