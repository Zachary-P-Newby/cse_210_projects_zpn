using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("Hello Foundation4 World!");
=======
        Running run = new Running(3, new DateOnly(2023, 11, 03), 30.00);

        Swimming swim = new Swimming(33, new DateOnly(2023, 11, 03), 30);

        Cycling cycle = new Cycling(25, new DateOnly(2023, 11, 03), 32.5);

        List<Activity> _activities = new List<Activity>(3);

        _activities.Add(run);
        _activities.Add(swim);
        _activities.Add(cycle);

        _activities.ForEach(item => {
            Console.WriteLine(item.GetSummary());
            Console.WriteLine("");
        });
>>>>>>> parent of 752f081 (Created New Sandbox)
    }
}