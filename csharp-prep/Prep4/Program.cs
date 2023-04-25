using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = 200;

        
        while (input != 0)
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            numbers.Add(input);
        }

        int total = 0;
        int largest = 0;
        int smp = 0;
        foreach (int num in numbers)
        {
            total += num;
            
            if (num > largest)
            {
                largest = num;
            }
            else if (num > 0 && num < smp)
            {
                smp = num;
            }
        }

        numbers.Sort();
        float average = total/(numbers.Count-1);

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive is: {smp}");
        Console.WriteLine("The ordered list is: ");
        
        foreach (int num in numbers)
        {
            Console.WriteLine($"{num}");
        }
    }
}