using System.Net;
public class ContentLoader

{
    public ContentLoader()
    {}

    public async Task DownloadMultipleTimes(string url)
    {
        for (int i = 0; i < 64; i++)
        {
            DownloadHTML(url);
        }
    }
    
    private string DownloadHTML(string url)
    {
        var webClient = new WebClient();
        return webClient.DownloadString(url);
    }
}