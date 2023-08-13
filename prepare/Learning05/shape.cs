public class Shape{

    protected String _color = "Red";

    public Shape(String color){
        _color = color;
    }

    public String GetColor(){
        return _color;
    }

    public void SetColor(String color){
        _color = color;
    }

    public virtual double GetArea(){
        return .00;
    }
}