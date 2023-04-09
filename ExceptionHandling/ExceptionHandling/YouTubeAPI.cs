internal class YouTubeFethingException : Exception
{
    public YouTubeFethingException(string message, Exception exception) : 
        base(message, exception)
    {}
}

class YouTubeAPI
{
    public YouTubeAPI()
    {
        try
        {
            Console.WriteLine("Trying to feth the video...");
            throw new Exception("Exception for trace");
        }
        catch (Exception e)
        {
            throw new YouTubeFethingException("Oops.. Something went wrong with fetching...", e);
        }
        
    }
}