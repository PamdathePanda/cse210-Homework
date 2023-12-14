using System.ComponentModel.Design;

abstract class Activity{


    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int Length)
    {
        _date = date;
        _length = Length;
    }
    public int Length
    {
        get { return _length; }
    }
    abstract public double Distance();
    abstract public double Speed();
    abstract public double Pace();
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_length} min): " +
            $"Distance: {this.Distance():F2} miles, Speed: {this.Speed():F2} mph, Pace: {this.Pace():F2} min per mile";
    }
}