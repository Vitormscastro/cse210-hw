using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string string_grade = Console.ReadLine();
        int grade = int.Parse(string_grade);
        string grade_letter = "";
        string sign = "";
        string pass = "";

        if (grade >= 90)
        {
            grade_letter = "A";
            if(grade <= 93)
            {
                sign = "-";
            }
        }
        else if (grade >= 80)
        {
            grade_letter = "B";
            if (grade >= 87)
            {
                sign = "+";
            }
            if(grade <= 83)
            {
                sign = "-";
            }
        }
        else if (grade >= 70)
        {
            grade_letter = "C";
            if (grade >= 77)
            {
                sign = "+";
            }
            if(grade <= 73)
            {
                sign = "-";
            }
        }
        else if (grade >= 60)
        {
            grade_letter = "D";
            if (grade >= 67)
            {
                sign = "+";
            }
            if(grade <= 63)
            {
                sign = "-";
            }
        }
        else
        {
            grade_letter = "F";
        }

        if (grade >= 70)
        {
            pass = "You passed! ";
        }
        else
        {
            pass = "You'll get it next semester!"; 
        }

        Console.WriteLine($"{pass}You received the following grade: {grade_letter}{sign}");
    }
}