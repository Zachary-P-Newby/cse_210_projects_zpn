public class Lecture: Event{

    private string _speaker;
    private string _topic;
    private int _capacity;

    public Lecture(String eventTitle, String description, DateTime dateAndTime, Address address, string speaker, string topic, int capacity):base(eventTitle, description, dateAndTime, address){
        _speaker = speaker;
        _topic = topic;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{_eventTitle} - {GetDate()} {_time}, {_address.GetShortAddress()}\n    Topic: {_topic} | Speaker: {_speaker} | Max Capacity: {_capacity}\n     {_description}";
    }

    public string GetSpeaker(){
        return _speaker;
    }

    public string GetTopic(){
        return _topic;
    }

    public int GetCapacity(){
        return _capacity;
    }

}