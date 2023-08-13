using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<String> _results = new List<string>();
        BreathingActivity _breathing = new BreathingActivity();
        ReflectionActivity _reflecting = new ReflectionActivity();
        ListingActivity _listing = new ListingActivity();


        void RecordResultsToFile(List<String> data){
        Console.Write("Enter new file name:");
                    string _newFileName = Console.ReadLine();
                    using(StreamWriter outputFile = new StreamWriter(_newFileName))
                        {
                            outputFile.WriteLine($"Date: {DateTime.Now}\n");

                            foreach(string line in data)
                                {outputFile.WriteLine($"{line}");}
                        }
    }

    void Menu(){
        Boolean running = true;
        while (running){

            Console.Clear();
        Console.WriteLine("Mindfullness Program");
        Console.WriteLine("Please select one of the following: (Numbers only)");
        Console.WriteLine("1: Breathing Activity");
        Console.WriteLine("2: Reflection Activity");
        Console.WriteLine("3: Listing Activity");
        Console.WriteLine("4: Save results to a file");
        Console.WriteLine("5: Quit");
        Console.Write("Select Option:");
        String choice = Console.ReadLine();

        if (choice == "1"){
            _breathing.RunActivity();
            _results.Add(_breathing.GetResults());
        }

        else if (choice == "2"){
            _reflecting.RunActivity();
            _results.Add(_reflecting.GetResults());
        }
        else if (choice == "3"){
            _listing.RunActivity();
            _results.Add(_listing.GetResults());
        }
        else if (choice == "4"){
            RecordResultsToFile(_results);
        }
        else if (choice == "5"){
            Console.WriteLine("Goodbye");
            running = false;
        }
        else{
            Console.WriteLine("Invalid, wait and enter again.");
            Thread.Sleep(1000);
            continue;
        }
        }
        
    }
    /* Run Program */
    Menu();

        
    }
}