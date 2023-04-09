Console.WriteLine("Time before load" + DateTime.Now);

var contentLoader = new ContentLoader();
var task = contentLoader.DownloadMultipleTimes("https://learn.microsoft.com/ru-ru/dotnet/csharp/");


Console.WriteLine("Time after loading " + DateTime.Now);

Console.ReadLine();