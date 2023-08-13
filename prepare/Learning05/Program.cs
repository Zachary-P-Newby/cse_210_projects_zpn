using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myList = new List<Shape>();

        myList.Add(new Square("red", 3));
        myList.Add(new Circle("Blue", 2));
        myList.Add(new Rectangle("Yellow", 2.60, 5));

        foreach(Shape item in myList){
            Console.WriteLine($"Color: {item.GetColor()}\nArea: {item.GetArea()}");
        }
    }
}