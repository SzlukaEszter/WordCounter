using System;
using System.IO;

public class FileReader : IReader
{
	public string ReadContent(string pathName)
	{
		return File.ReadAllText(pathName);
	}

}
