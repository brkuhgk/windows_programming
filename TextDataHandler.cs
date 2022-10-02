using System;
using System.Runtime.CompilerServices;

public class TextDataHandler
{
	
	
	private static StreamReader reader;

	public TextDataHandler(String filename)
	{

		FileInfo fi = new FileInfo(filename);
		reader = fi.OpenText();
    }

	public string read()
	{
		string data = "";
		string str = "";

		while( (data = reader.ReadLine()) != null)
		{
			//Console.WriteLine(data);
			str = str + data + " ";
		}
		return str;
	}
    public void close()
	{
		reader.Close();
	}


}
