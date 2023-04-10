var contentLoader = new ContentLoader();
contentLoader.DownloadMultipleTaskAsync("https://learn.microsoft.com/ru-ru/dotnet/csharp/");
Console.WriteLine("Another jobs in main thread...");

Console.ReadLine();