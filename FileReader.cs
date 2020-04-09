using System;
using System.IO;

public class FileReader
{
	public FileReader(string fileName)
	{
		this.FileName = fileName;
	}

	public string FileName {get; set;}

	public String[] GetWords()
	{
		string text = File.ReadAllText(FileName);
		string[] separators = { " ", ".", ",", "!", ":", ";", "-", "?", "(", ")", "{", "}", "[", "]","\'", "\r\n", "\t" };
		string[] wordArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		return wordArr;
	}




}
