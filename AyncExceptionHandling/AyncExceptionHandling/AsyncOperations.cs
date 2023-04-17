static class AsyncOperations
{
    public static async Task PrintAsyncTask(string message){
        if (message.Length < 4)
        {
            throw new Exception("Message length less than 4");
        }

        await Task.Delay(3000);
        Console.WriteLine($"The message is {message}");
    }
    
    public static async void PrintAsyncVoid(string message)
    {
        try
        {
            await PrintAsyncTask(message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}