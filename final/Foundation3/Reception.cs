class Reception : Event {
    //For receptions this includes an email for RSVP.
    private string _rsvpEmail;

    public Reception(string Title, string Description, DateTime Date, DateTime Time, Address Address, string EventType, string RSVPEmail): base(Title, Description, Date, Time, Address, EventType){
        _rsvpEmail = RSVPEmail;
    }

    public override string FullDetails(){
        return base.FullDetails() + $" {_rsvpEmail}";
    }
}   
 