using System;
using System.Globalization;

public class StudentData
{
	public string student_id = "";
	public double student_score;

	public StudentData(string str)
	{
		string[] strArr = str.Split(" ");
        student_id = strArr[0];
        student_score = Convert.ToDouble(strArr[1]);

    }


}
