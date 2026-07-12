using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Net.Http;

namespace CSharp_Fundamentals;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();

        Console.WriteLine("Starting download...");

        Task<string> downloadTask =
            client.GetStringAsync("https://www.google.com");

        // While download is happening...
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(".");
            await Task.Delay(200);
        }

        string html = await downloadTask;

        Console.WriteLine();
        Console.WriteLine($"Downloaded {html.Length} characters.");
    }
}

