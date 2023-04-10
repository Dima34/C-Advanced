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

    public void DownloadMultipleTimes(string url)
    {
        for (int i = 0; i < 64; i++)
        {
            DownloadHTML(url);
        }

        Console.WriteLine("Loaded multiple times");
    }
    
    private string DownloadHTML(string url)
    {
        var webClient = new WebClient();
        return webClient.DownloadString(url);
    }
}