using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Momo Inc.";
        job1._startYear = 2016;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Game Designer";
        job2._company = "Ruby Co.";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume my_res = new Resume();
        my_res._name = "Zach Newby";
        my_res._jobs = new List<Job> {job1, job2};

        my_res.Display();
    }
}