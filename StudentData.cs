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

	/*private Queue<string> q = new Queue<string>();
    public StudentData(string str)
	{
		str = str.Trim();
		string[] strArr = str.Split(" ");
		for(int i = 0; i < strArr.Length; i++)
		{
			q.Enqueue(strArr[i]);
		}

	}*/

/*
    public void getLine()
	{
        student_id = q.Peek();
		q.Dequeue();	
		student_score = Convert.ToDouble(q.Peek());
		q.Dequeue();
    }
*/


}
