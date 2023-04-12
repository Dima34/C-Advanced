using System.Net;
public class ContentLoader
{
    public ContentLoader()
    {}

    public async Task DownloadMultipleTaskAsync(string url)
    {
        Console.WriteLine("Loading start..." + DateTime.Now);
        await Task.Run(() => DownloadMultipleTimes(url));
        Console.WriteLine("Loading end " + DateTime.Now);
    }

    public async Task WaitForAsync(string name)
    {
        Console.WriteLine($"Waiting for {name}");
        await Task.Delay(3000);
        Console.WriteLine($"{name} is here!");
    }

    public void DownloadMultipleTimes(string url)
    {
        for (int i = 0; i < 64; i++)
        {
            DownloadHTML(url);
        }

        Console.WriteLine("Loaded multiple times");
    }

    public Func<string, Task> delayedPrinter = async (string message) =>
    {
        await Task.Delay(3000);
        Console.WriteLine($"*Delayed printer* {message}");
    };
    
    private string DownloadHTML(string url)
    {
        var webClient = new WebClient();
        return webClient.DownloadString(url);
    }
}