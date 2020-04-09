using System;

//[Serializable]
public class CouldNotReadException : Exception
{
	public CouldNotReadException() { }

	public CouldNotReadException(string message) : base(message) {}
}
