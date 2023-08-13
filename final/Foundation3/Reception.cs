public class Reception: Event{
    private List<String> _guestList;
    private string _emailAddress;

    public Reception(String eventTitle, String description, DateTime dateAndTime, Address address, String emailAddress):base(eventTitle, description, dateAndTime, address){
        _emailAddress = emailAddress;
    }
    public Reception(String eventTitle, String description, DateTime dateAndTime, Address address, List<String> guestList, String emailAddress):base(eventTitle, description, dateAndTime, address){
        _guestList = guestList;
        _emailAddress = emailAddress;
    }


    public void AddGuest(String guest){
        _guestList.Add(guest);
    }

    public List<String> GetGuestList(){
        return _guestList;
    }
    public void SetGuestList(List<String> guestList){
        _guestList = guestList;
    }

    public string GetEmailAddress(){
        return _emailAddress;
    }

    public void PrintGuestList(){
        Console.WriteLine($"{_eventTitle} Guest List:");
        _guestList.ForEach(item =>{
            Console.WriteLine($"- {item}");
        });
    }

    public override string GetFullDetails()
    {
        return $"{_eventTitle} - {GetDate()} {_time}, {_address.GetShortAddress()} RSVP Email: {this._emailAddress}\n    {_description}";
    }
}