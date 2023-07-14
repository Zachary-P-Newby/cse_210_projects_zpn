public class Activity{

    protected string _name;
    protected DateOnly _date;
    protected double _minutes = 0.0;
    
    /* I changed _length to _minutes as it felt more semantic and readable */
    public Activity(DateOnly date, double minutes){
        _date = date;
        _minutes = minutes;
        _name = $"{this.GetType()}";
    }

    public string GetDate(){
        
        int _rawDay = _date.Day;
        int _rawMonth = _date.Month;
        string _day = "";
        string _month = "";

        if(_rawDay < 10){
            _day = $"0{_rawDay}";
        }
        else{
            _day = $"{_rawDay}";
        }

        switch(_rawMonth){
            case 1:
                _month = "Jan";
            break;

            case 2:
                _month = "Feb";
            break;

            case 3:
                _month = "Mar";
            break;

            case 4:
                _month = "Apr";
            break;

            case 5:
                _month = "May";
            break;

            case 6:
                _month = "Jun";
            break;

            case 7:
                _month = "Jul";
            break;

            case 8:
                _month = "Aug";
            break;

            case 9:
                _month = "Sep";
            break;

            case 10:
                _month = "Oct";
            break;

            case 11:
                _month = "Nov";
            break;

            case 12:
                _month = "Dec";
            break;
        };
        
        return $"{_day} {_month} {_date.Year}";
    }

    public double GetMinutes(){
        return _minutes;
    }

    public string GetName(){
        return _name;
    }

    public void SetMinutes(double minutes){
        _minutes = minutes;
    }

    public void GetName(string name){
        _name = name;
    }

    public void SetDate(DateOnly date){
        _date = date;
    }

    virtual protected double CalculateDistance(){
        return _minutes;
    }

    virtual protected double CalculateSpeed(){
        return (CalculateDistance()/ _minutes) * 60;
    }

    virtual protected double CalculatePace(){
        return _minutes / CalculateDistance();
    }

    public String GetSummary(){
        return $"{GetDate()} {_name} ({_minutes} min)- Distance: {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}