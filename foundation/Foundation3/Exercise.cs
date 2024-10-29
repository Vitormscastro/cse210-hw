using System;

public abstract class Exercise
{
    protected string _date;
    protected int _length;

    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract int GetDistance();
    public abstract int GetSpeed();
    public abstract int GetPace();
    public abstract string GetSummary();
}