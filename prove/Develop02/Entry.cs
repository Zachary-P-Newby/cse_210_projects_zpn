public class Entry{

    public string _userText;

    public string _prompt;

    public string _fullEntry;

    public string _creationDate;
    public List<string> _prompts = new List<string>
{"What is the airspeed of an unladen swallow?",
"Where have you seen God's hand in your life today?",
"Who is an interesting person you met today?",
"If you could have a do-over of today, what would you do differently?",
"What is a good thing that happend to you today",
"What are you grateful for today?"
};

    public Entry()
    {
        this._creationDate =DateTime.Now.ToShortDateString();

        Random rnd = new Random();
        this._prompt = this._prompts[rnd.Next(1, 6)];

        Console.WriteLine(this._prompt);
        Console.Write("     >");
        this._userText = Console.ReadLine() ;
        this._fullEntry = "\n" + this._creationDate + "\nPrompt: " + this._prompt + "\n" + this._userText;
    }

    public void Display()
    {
        Console.WriteLine(this._fullEntry);
    }

}