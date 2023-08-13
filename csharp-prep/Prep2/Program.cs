using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade Points: ");
        string gradeString = Console.ReadLine();

        int gradeInt = int.Parse(gradeString);
        string Grade;

        if (gradeInt >= 90)
        {
            Grade = "A";
        }
        else if (gradeInt>= 80)
        {
            Grade = "B";
        }
        else if (gradeInt >= 70)
        {
            Grade = "C";
        }
        else if (gradeInt >= 60)
        {
            Grade = "D";
        }
        else
        {
            Grade = "F";
        }

         string Sign;

         if (gradeInt >= 100)
         {
            Sign = "";
         }
         else if ((gradeInt % 10 >= 7) && Grade != "A" && Grade != "F")
         {
            Sign = "+";
         }
         else if ((gradeInt % 10 <= 3) && Grade != "F")
         {
            Sign = "-";
         }
         else
         {
            Sign = "";
         }




        Console.WriteLine($"Your grade is {Grade + Sign}");

    }
}