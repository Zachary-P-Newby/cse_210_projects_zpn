public class Swimming: Activity{
    private int _laps;

    public Swimming(int laps, DateOnly date, double minutes):base(date, minutes){
        _laps = laps;
    }

    public int GetLaps(){
        return _laps;
    }

    public void SetLaps(int laps){
        _laps = laps;
    }

    protected override double CalculateDistance()
    {
        return Math.Round(_laps * 50/1000 * 0.62, 2);
    }

    protected override double CalculateSpeed()
    {
        return Math.Round((CalculateDistance() / _minutes) * 60, 2);
    }

    protected override double CalculatePace()
    {
        return Math.Round(_minutes / CalculateDistance(), 2);
    }
}