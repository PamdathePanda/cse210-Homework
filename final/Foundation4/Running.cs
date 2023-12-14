class Running : Activity
{
    private int _distance;

    public Running(DateTime date, int Length, int Distance) : base(date, Length)
    {
        _distance = Distance;
    }

    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance / this.Length * 60;
    }
    public override double Pace()
    {
        return this.Length / _distance;
    }
}
