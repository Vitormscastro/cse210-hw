public class Cycling : Exercise
{
    protected int _speed;

    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override int GetDistance()
    {
        return (_speed * _length) / 60;
    }
    public override int GetSpeed()
    {
        return _speed;
    }
    public override int GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {GetDistance()} Km, Speed {GetSpeed()} Km/h, Pace: {GetPace()} min per Km";
    }
}