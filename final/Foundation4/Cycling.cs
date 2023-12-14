class Cycling : Activity
{
    private int _speed;

    public Cycling(DateTime date, int Length, int speed) : base(date, Length)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed * (this.Length / 60.0);
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return 60 / _speed;
    }
}
