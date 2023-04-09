StreamReader sr = null;

try
{
    sr = new StreamReader("./testFoledr/...");
    throw new Exception("Oops..."); 
}
catch
{
    Console.WriteLine("Something went wrong...");
}
finally
{
    sr?.Dispose();
    Console.WriteLine("Finnaly...");
}

// variant 2 with "using" using
try
{
    using (sr = new StreamReader("./testFoledr/..."))
    {
        //some routine with sr...
        throw new Exception("Oops...");
    }
    
    //  and after using ended Dispose will be called in sr.
}
catch
{
    Console.WriteLine("Something went wrong...");
}

new YouTubeAPI();

Console.WriteLine("End of program");
Console.ReadLine();

float Divide(int a, int b)
{
    return a / b;
}