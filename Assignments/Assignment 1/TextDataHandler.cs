using System;


public class TextDataHandler
{
	StreamReader StreamReader;
	public TextDataHandler(string filename)
	{
		try
		{
            StreamReader = new StreamReader(filename); 
		}
		catch(Exception e)
		{
            Console.WriteLine("This file could not be read: ");
            Console.WriteLine(e.Message);
		}

    }
	public String Read()
	{	

		return new String(StreamReader.ReadLine());
	}
	public void Close()
	{
		StreamReader.Close();
	}


}
