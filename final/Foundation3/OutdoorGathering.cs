public class OutdoorGathering: Event{
    private string _weatherCondition;
    public OutdoorGathering(String eventTitle, String description, DateTime dateAndTime, Address address, String weatherCondition):base(eventTitle, description, dateAndTime, address){
    _weatherCondition = weatherCondition;
    }

    public String GetWeatherCondition(){
        return _weatherCondition;
    }

    public override string GetFullDetails()
    {
        return $"{_eventTitle} - {GetDate()} {_time}, {_address.GetShortAddress()}\n    Weather Conditons: {_weatherCondition}\n    {_description}";
    }

}