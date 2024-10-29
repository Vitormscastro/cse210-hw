public class Swimming : Exercise
{
    protected int _numberOfLaps;

    public Swimming(string date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override int GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }
    public override int GetSpeed()
    {
        return 60 / GetPace();
    }
    public override int GetPace()
    {
        return (_length / GetDistance());
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min) - Distance {GetDistance()} Km, Speed {GetSpeed()} Km/h, Pace: {GetPace()} min per Km";
    }
}