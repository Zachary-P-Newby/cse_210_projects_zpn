using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Order 1
        Product s1 = new Product("Sonic Plushie", "1991a", 8.50, 2);
        Product s2 = new Product("Pikmin Adventure VHS Tape", "2051b", 12.54, 1);
        Product s3 = new Product("Rubber Ducky", "4521D", 4.24, 8);

        List<Product> order1List= new List<Product>(3);
        order1List.Add(s1);
        order1List.Add(s2);
        order1List.Add(s3);

        Customer ZachN = new Customer("Zach Newby", new Address(506, "Sunnybrook Rd", "Carl Junction", "Missouri", "USA"));

        Order Order1 = new Order(ZachN, order1List);



        //Order 2
        Product m1 = new Product("Mini Chocolate Glazed Doughnuts", "4976C", 7.49, 3);
        Product m2 = new Product("Banana Taffy - 1lb Bag", "8424N", 5.86, 1);
        Product m3 = new Product("Majestic Painting", "5575K", 34.43, 1);

        List<Product> order2List= new List<Product>(3);
        order2List.Add(m1);
        order2List.Add(m2);
        order2List.Add(m3);

        Customer MayR = new Customer("May Rivers", new Address(214, "Wellington St", "Yorkshire", "England", "United Kingdom"));

        Order Order2 = new Order(MayR, order2List);

        //print data

        //order 1
        Console.WriteLine("---------------");
        Console.WriteLine("Order 1");
        Console.WriteLine(Order1.GetShippingLabel());
        Console.WriteLine(Order1.GetPackingLabel());
        Console.WriteLine($"Total Price: {Order1.GetTotalPrice()}");
        
        Console.WriteLine("");

        //order 2
        Console.WriteLine("---------------");
        Console.WriteLine("Order 2");
        Console.WriteLine(Order2.GetShippingLabel());
        Console.WriteLine(Order2.GetPackingLabel());
        Console.WriteLine($"Total Price: {Order2.GetTotalPrice()}");
        Console.WriteLine("---------------");
        
    }
}