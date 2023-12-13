using System.Reflection;

class Lecture : Event{
    // the speaker name and capacity.
    private string _speakerName;
    private int _seats;

    public Lecture(string Title, string Description, DateTime Date, DateTime Time, Address Address, string EventType, string SpeakerName, int Seats): base(Title, Description, Date, Time, Address, EventType){
        _speakerName = SpeakerName;
        _seats = Seats;
    }
    public override string FullDetails(){
        return base.FullDetails() + $" {_speakerName} {_seats}";
    }
}
