public class Comment{
    private String _author = "Author";
    private String _content ="";

    public Comment(string author, string content){
        _author = author;
        _content = content;
    }

    public String GetAuthor(){
        return _author;
    }

    public void SetAuthor(String author){
        _author = author;
    }

    public String GetContent(){
        return _content;
    }

    public void SetContent(String content){
        _author = content;
    }

    public String GetComment(){
        return $"{_author}:\n    {_content}\n----------";
    }
}