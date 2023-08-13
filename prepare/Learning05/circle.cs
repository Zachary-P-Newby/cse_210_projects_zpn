public class Circle: Shape{

    double _radius;
    public Circle(String color, double radius): base(color){
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * Math.PI * _radius;
    }
}