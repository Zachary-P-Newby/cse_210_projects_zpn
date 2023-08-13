using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction five = new Fraction(6);
        Fraction half = new Fraction(6,7);
        Fraction sevenFive = new Fraction(7,5);
        Fraction threeFourths = new Fraction(3,4);
        Fraction threeFifths = new Fraction(3);
        threeFifths.SetBottomValue(5);

        //Tested half._bottom = 2;
        //Got an error :)

        //one test
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        
        //Five test
        five.SetTopValue(5);
        Console.WriteLine(five.GetFractionString());

        int numerator = one.GetTopValue();
        int denominator = five.GetTopValue();

        Fraction oneFifth = new Fraction(numerator, denominator); 
        
        //half test
        Console.WriteLine(half.GetFractionString());
        half.SetTopValue(1);
        half.SetBottomValue(2);
        Console.WriteLine(half.GetFractionString());
        Console.WriteLine(half.GetDecimalValue());

        Console.WriteLine(sevenFive.GetDecimalValue());
        Console.WriteLine(threeFourths.GetDecimalValue());
        Console.WriteLine(threeFifths.GetDecimalValue());

        Console.WriteLine(oneFifth.GetFractionString());
        Console.WriteLine(oneFifth.GetDecimalValue());
    }
}
