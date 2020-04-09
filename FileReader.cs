using System;
using System.IO;

public class FileReader
{
	public String[] GetWords(string pathName)
	{
		string text = File.ReadAllText(pathName);
		string[] separators = { " ", ".", ",", "!", ":", ";", "-", "?", "(", ")", "{", "}", "[", "]","\'", "\r\n", "\t" };
		string[] wordArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		return wordArr;
	}

}
