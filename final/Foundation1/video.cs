public class Video{
    private String _title = "Title";
    private String _author = "Rip Techno";
    private int _length = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video(){}
    
    public Video(String title, String author, int length, List<Comment> comments){
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;

    }

    public Video(String title, String author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    

    public String GetTitle(){
        return _title;
    }
    public void SetTitle(string title){
        _title = title;
    }
    public String GetAuthor(){
        return _author;
    }
    public void SetAuthor(String author){
        _author = author;
    }
    public int GetLength(){
        return _length;
    }
    public void SetLength(int length){
        _length = length;
    }
    public List<Comment> GetComments(){
        return _comments;
    }
    public void SetComments(List<Comment> comments){
        _comments = comments;
    }
    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public void PrintInfo(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength (Seconds): {_length}\nComments: {_comments.Count}");
    }

    public void PrintComments(){
        _comments.ForEach(comment =>{
            Console.WriteLine();
            Console.WriteLine(comment.GetComment()); 
        });
    }


}
