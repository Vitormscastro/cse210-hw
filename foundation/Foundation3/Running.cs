public class Running : Exercise
{
    protected int _distance;

    public Running(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public override int GetDistance()
    {
        return _distance;
    }
    public override int GetSpeed()
    {
        return 60 / GetPace();
    }
    public override int GetPace()
    {
        return _length / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance {GetDistance()} Km, Speed {(float)GetSpeed()} Km/h, Pace: {GetPace()} min per Km";
    }
}