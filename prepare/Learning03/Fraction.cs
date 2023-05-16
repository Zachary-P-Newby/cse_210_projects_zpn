public class Fraction
{
    private int _top;
    // Why not call them numerator and denominator?
    private int _bottom;
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public int GetTopValue(){
        return _top;
    }

    public void SetTopValue(int top){
        _top = top;
    }

    public int GetBottomValue(){
        return _bottom;
    }

    public void SetBottomValue(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }

}