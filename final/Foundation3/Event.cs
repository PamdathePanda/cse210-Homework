public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string Title, string Description, DateTime Date, DateTime Time, Address Address, string EventType){
        _title = Title;
        _description = Description;
        _date = Date.ToShortDateString();
        _time = Time.ToShortTimeString();
        _address = Address;
        _eventType = EventType;
    }

    public string StandardDetails(){
        return $"{_title}, {_description}, {_date}, {_time}, {_address.ReturnAddress()}";

    }
    public string ShortDescription(){
        return $"{_eventType}, {_title}, {_date}";
    }

    public virtual string FullDetails(){
        return $"{_title}, {_description}, {_date}, {_time}, {_address.ReturnAddress()}";
    }
    
}
