public class Scripture{

    //Attributes
    private Reference _reference;

    private List<Word> _wordList = new List<Word>();

    public String _fullText = "";

    public Boolean _allWordsHidden = false;

    //Constructor

    public Scripture(Reference reference, String verseText){

        _reference = reference;


        var result = verseText.Split(" ");

         foreach(String item in result){
           _wordList.Add(new Word(item));
        }
            

        _fullText = $"{_reference.GetReference()}\n ";

        foreach (Word word in _wordList){
            
            _fullText += word.GetWord();
            _fullText += " ";
        }
    }

    public void RenderScripture(){
        Console.Clear();
        Console.WriteLine(_fullText);
    }

    public String GetFullText(){
        return _fullText;
    }



    public void HideWords(){
        Random rnd = new Random();
        int _wordsToHide = rnd.Next(1, _wordList.Count);

        for(int i = 0; i < _wordsToHide; i++){

            int _wordIndex = rnd.Next(0, _wordList.Count);

            if (_wordList[_wordIndex].GetIsHidden() == false){
                
                _wordList[_wordIndex].HideWord();
            }

            else{
                continue;
            }

        }
    }

    public void UpdateFulltext(){
        _fullText = $"{_reference.GetReference()} ";

        foreach (Word word in _wordList){
            
            _fullText += word.GetWord();
            _fullText += " ";
        }
    }

    public void CheckIfAllWordsHidden(){
        //Tallies number of hidden words, if all are hidden set _allWordsHidden to true, else false
        int _count = 0;

        foreach (Word word in _wordList){
            if (word.GetIsHidden()){
                _count += 1;
            }
        }

        if(_count == _wordList.Count){
            _allWordsHidden = true;
        }
        else{
            _allWordsHidden = false;
        }
    }

}