public class Event{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected String _time;
    protected Address _address;

    public Event(String eventTitle, String description, DateTime dateAndTime, Address address){
        _eventTitle = eventTitle;
        _description = description;
        _date = dateAndTime;
        SetTime(dateAndTime);
        _address = address;
    }

    public string GetStandardDetails(){
        return $"{_eventTitle} - {GetDate()} {_time}, {_address.GetShortAddress()}\n    {_description}";
    }

    virtual public string GetFullDetails(){
        return $"{_eventTitle} - {GetDate()} {_time}, {_address.GetShortAddress()}\n    {_description}";
    }

    public string GetShortDetails(){
        return $"{this.GetType()} - {_eventTitle} - {GetDate()}";
    }

    protected void SetTime(DateTime time){

        string minute;
        
        if(time.Minute < 10){
            minute = $"0{time.Minute}";
        }
        else{
            minute = $"{time.Minute}";
        }

        if(time.Hour == 0){
            _time = $"12:{minute} AM";
        }
        
        else if(time.Hour < 12){
            _time = $"{time.Hour}:{minute} AM";
        }

        else if(time.Hour == 12){
            _time = $"{time.Hour}:{minute} PM";
        }

        else{
            int hour = time.Hour;
            hour = hour - 12;
            _time = $"{hour}:{minute} PM";
        }
    }

    public string GetEventTitle(){
        return _eventTitle;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetDate(){
        return $"{_date.Month}/{_date.Day}/{_date.Year}";
    }
    public string GetTime(){
        return _time;
    }
    public string GetAddress(){
        return _address.GetShortAddress();
    }

}