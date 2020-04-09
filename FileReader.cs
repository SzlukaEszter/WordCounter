using System;
using System.IO;

public class FileReader : IReader
{
	public string ReadContent(string pathName)
	{
		try
		{
			return File.ReadAllText(pathName);
		}
		catch (FileNotFoundException e)
		{ 
			throw new CouldNotReadException(e.Message);
		}
	}

}
