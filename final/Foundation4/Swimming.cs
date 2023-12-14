class Swimming : Activity
{
    private int _laps;
        public Swimming(DateTime date, int Length, int Laps) : base(date, Length)
    {
        _laps = Laps;
    }

    public override double Distance()
    {
        return (_laps * 50.0) / 1000.0 * 0.62;
    }
    public override double Speed()
    {
        return this.Distance() / this.Length * 60;
    }
    public override double Pace()
    {
        if (this.Distance() == 0)
        {
            return 0;
        }

        return this.Length / this.Distance();
    }
}
