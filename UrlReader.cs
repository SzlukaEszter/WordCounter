using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

/// <summary>
/// Reads from a URL.
/// </summary>
public class UrlReader : IReader
{
    /// <summary>
    /// Creates a new instance of <see cref="UrlReader"/>.
    /// </summary>
    public UrlReader()
    {
    }

    /// <summary>
    /// Reads
    /// </summary>
    /// <param name="pathName"></param>
    /// <returns>A string containing the content read.</returns>
    public async Task<string> ReadContentAsync(string pathName)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using (var client = new HttpClient())
        {
            try
            {
                var bytes = await client.GetByteArrayAsync(pathName);

                return Encoding.GetEncoding(1252).GetString(bytes);
            }
            catch (System.AggregateException e)
            {
                throw new CouldNotReadException(e.Message);
            }
        }
    }
}
