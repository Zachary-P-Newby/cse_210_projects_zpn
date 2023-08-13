using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("Hello Foundation3 World!");
=======
        Event convention = new Event("Astral Con", "Astral Con Comics and Video Games Convention", new DateTime(2023, 9, 11, 11, 0, 0), new Address(2187, "Star Rd.", "Joplin", "MO", "USA"));

        Lecture JP_Lecture = new Lecture("Meme Psychology Speech", "Jordan B. Peterson will speak on the psychology behind memes", new DateTime(2023, 7, 20, 14, 0, 0), new Address(413, "John St", "Joplin", "MO", "USA"), "Jordan B. Peterson", "Meme Psychology", 45);
        
        OutdoorGathering picnic = new OutdoorGathering("Zach Co. Company Picnic", "The Zach Co. Company Picnic will feature a variety of foods, games, and family friedly actvities, inclduing a speech by our illustrious CEO", new DateTime(2023, 9, 16, 12, 0, 0), new Address(1, "Pothole Rd", "Joplin", "Mo", "USA"), "Sunny at 75 degrees");
     
        List<String> guestList1 = new List<string>(20);
        guestList1.Add("Hank Johnson");
        guestList1.Add("Laura Mason");
        guestList1.Add("William Johnson");
        guestList1.Add("Sally Johnson");
        guestList1.Add("Mason Mason");
        guestList1.Add("Cassandra Mason");
        guestList1.Add("Ruth Duluth Johnson");
        guestList1.Add("Clem Johnson");
        guestList1.Add("Arthur Johnson");
        guestList1.Add("McKenzie McKinnon");
        guestList1.Add("Sam Roberts");
        guestList1.Add("Enrique Martinez");
        guestList1.Add("Miley O'Riley");

        Reception wedding = new Reception("Johnson Wedding Reception", "The Wedding reception of Hank Johnson and Laura Mason", new DateTime(2023, 9, 16, 17, 30, 0), new Address(814, "Eagret Ln", "Bentonvile", "AK", "USA"), guestList1, "johnsonwedding1@tempmail.com");
        

        /* MEssages */
        Console.WriteLine(convention.GetStandardDetails());
        Console.WriteLine(convention.GetFullDetails());
        Console.WriteLine(convention.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine(JP_Lecture.GetStandardDetails());
        Console.WriteLine(JP_Lecture.GetFullDetails());
        Console.WriteLine(JP_Lecture.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine(picnic.GetStandardDetails());
        Console.WriteLine(picnic.GetFullDetails());
        Console.WriteLine(picnic.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine(wedding.GetStandardDetails());
        Console.WriteLine(wedding.GetFullDetails());
        Console.WriteLine(wedding.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine("I also made a guest list and function to print it");
        wedding.PrintGuestList();
>>>>>>> parent of 752f081 (Created New Sandbox)
    }
}