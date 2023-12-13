class Outdoor : Event{
    // this includes a statement of the weather.
    private string _weather;
    public Outdoor(string Title, string Description, DateTime Date, DateTime Time, Address Address, string EventType, string Weather): base(Title, Description, Date, Time, Address, EventType){
        _weather = Weather;
    }
    public override string FullDetails(){
        return base.FullDetails() + $" {_weather}";
    }
}
