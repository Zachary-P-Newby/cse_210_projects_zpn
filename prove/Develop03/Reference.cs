public class Reference{
    //Attributes

    private String _book;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public String _fullReference;
    
    //Constructor
    public Reference(String book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        
        _fullReference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
    }

    public Reference(String book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
        
        _fullReference = $"{_book} {_chapter}: {_startVerse}";
    }

    public void SetReference(String book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        
        _fullReference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
    }

    public void SetReference(String book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
        
        _fullReference = $"{_book} {_chapter}: {_startVerse}";
    }

    public String GetReference(){
        return _fullReference;
    }
}