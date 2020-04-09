using System;
using System.Net.Http;

public class UrlReader : IReader
{
	public string ReadContent(string pathName)
	{
		HttpClient client = new HttpClient();
		try
		{
			return client.GetStringAsync(pathName).Result;
		}
		catch (System.AggregateException e)
		{
			throw new CouldNotReadException(e.Message);
		}

	}
}
