using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ascii = new Assignment("Zach", "ASCII");

        String result = ascii.GetSummary();

        Console.WriteLine(result);

        MathAssignment math = new MathAssignment("Bob", "Long Division", "5.6", "11-20");

        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment essay = new WritingAssignment("Joe", "Biology", "South American Paleontology");

        Console.WriteLine(essay.GetWritingInformation());
    }
}