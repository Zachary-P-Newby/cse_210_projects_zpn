using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> _journal = new List<Entry>();
        List<String> _activeFile = null;
        
        void NewEntry(){
            Entry _new = new Entry();
                _journal.Add(_new);
        }
        
        void DisplayEntries(){
            if (_journal == null){
                Console.WriteLine("No entries. Please create some.");
            }
            foreach(Entry item in _journal)
                    {item.Display();}
        }

        void LoadJournal(){
            if (_activeFile == null){
                _activeFile = new List<String>();
            }
            
            Console.Write("Enter file path:");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    _activeFile.Add(line);
                }
        }

        void SaveJournal(){
            Console.Write("Enter new file name:");
                    string _newFileName = Console.ReadLine();
                    using(StreamWriter outputFile = new StreamWriter(_newFileName))
                        {
                            foreach(String line in _activeFile)
                                {outputFile.WriteLine($"{line}");}
                            foreach(Entry item in _journal)
                                {outputFile.WriteLine($"{item._fullEntry}");}
                        }
        }


        void UI()
        {
            string userInput = null;
            while(userInput != "5")
            {
                
                Console.WriteLine(@"
                Please select one of the following (Use Numbers 1-5):
                1. Create an Entry
                2. Display an entry
                3. Load an Journal
                4. Save your Journal
                5. End the Program
                ");
                userInput = Console.ReadLine();
                
                if (userInput == "1"){
                    NewEntry();
                    }

                else if (userInput == "2"){
                    DisplayEntries();
                    }
                
                else if (userInput == "3"){
                    LoadJournal();
                    }

                else if (userInput == "4"){
                    SaveJournal();
                    }

                else if (userInput == "5"){
                    Console.WriteLine("Goodbye");
                }

                else{
                    Console.WriteLine("Invalid input. Please enter a number from one to five.");
                }
        
            }

        }

    UI();

    }

}
