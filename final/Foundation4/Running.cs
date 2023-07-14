public class Running: Activity{
    private double _distance = 0;

    public Running(double distance, DateOnly date, double minutes):base(date, minutes){
        _distance = distance;
    }

    public double GetDistance(){
        return _distance;
    }

    public void GetDistance(double distance){
        _distance = distance;
    }

    protected override double CalculateDistance()
    {
        return _distance;
    }

    protected override double CalculateSpeed()
    {
        return ( _distance / _minutes) * 60;
    }

    protected override double CalculatePace()
    {
        return _minutes / _distance;
    }
}