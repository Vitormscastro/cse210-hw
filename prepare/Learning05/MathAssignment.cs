using System;

public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string summary = base.GetSummary();
        return $"{summary}\n{_section} - {_problems}\n";
    }
}