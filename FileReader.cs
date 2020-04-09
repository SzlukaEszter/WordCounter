using System;
using System.IO;
using System.Threading.Tasks;

public class FileReader : IReader
{
	public async Task<string> ReadContentAsync(string pathName)
	{ 
		try
		{	Task<string> tsk = File.ReadAllTextAsync(pathName);
			string str = await tsk;

			return str;
		}
		catch (FileNotFoundException e)
		{ 
			throw new CouldNotReadException(e.Message);			 
		}
	}

	public async Task Method()
	{ }
}
