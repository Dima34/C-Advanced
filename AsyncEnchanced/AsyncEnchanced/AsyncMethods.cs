static class AsyncMethods
{
    public static async Task PrintAsync(string str, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"Delayed message: {str}");
    }

    public static async Task<int> MultiplyAsync(int a, int b)
    {
        await Task.Delay(a * 500);
        return a * b;
    }
}