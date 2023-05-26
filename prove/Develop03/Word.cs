public class Word{
    //Attributes

    private String _word;

    private String _blank = "";

    private Boolean _isHidden;

    public Word(String word, bool isHidden){
        _word = word;

        foreach (var item in word)
        {
            _blank += "_";
        }
        
    }

    public Word(String word){
        _word = word;

        _isHidden = false;

        foreach (var item in word)
        {
            _blank += "_";
        }
        
    }

    public String GetWord(){
        if (_isHidden == false){
            return _word;;
        }
        else{
            return _blank;
        }
        
        
    }

    public void SetWord(String word){
        _word = word;

        foreach (var item in word)
        {
            _blank += "_";
        }
    }

    public void SetWord(String word, bool isHidden){
        _word = word;

        _isHidden = isHidden;

        foreach (var item in word)
        {
            _blank += "_";
        }
    }

    public void HideWord(){
        if (_isHidden == false){
            _isHidden = true;
        }
        else{
            _isHidden = false;
        }
        
    }

    public bool GetIsHidden(){
        return _isHidden;
        
        
    }

}