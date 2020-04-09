using System;
using System.Threading.Tasks;

public interface IReader
{
    Task<string> ReadContentAsync(string pathName);
}
