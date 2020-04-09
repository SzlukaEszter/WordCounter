using System;
using System.Net.Http;

public class UrlReader : IReader
{
	public string ReadContent(string pathName)
	{
		HttpClient client = new HttpClient();
		return client.GetStringAsync("https://example.com/test.txt").Result;

	}
}
