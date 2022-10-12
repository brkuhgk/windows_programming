using System;

public class StudentData
{
    public string student_id = "";
    public float student_score = 0.0f;

    public StudentData(string studentInfo)
    {
        studentInfo = studentInfo.Trim();
        string[] Arrstr = studentInfo.Split(" ");
        student_id = Arrstr[0];
        student_score = float.Parse(Arrstr[1]);
    }
}
