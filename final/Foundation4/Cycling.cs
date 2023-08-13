public class Cycling: Activity{
    private double _speed;

    public Cycling(double speed, DateOnly date, double minutes):base(date, minutes){
        _speed = speed;
    }

    public double GetSpeed(){
        return _speed;
    }

    public void Setspeed(double speed){
        _speed = speed;
    }

    protected override double CalculateDistance()
    {
        return Math.Round(_speed * (_minutes / 60 ), 2);
    }

    protected override double CalculateSpeed()
    {
        return _speed;
    }

    protected override double CalculatePace()
    {
        return Math.Round(60 / _speed, 2);
    }
}