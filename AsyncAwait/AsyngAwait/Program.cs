var contentLoader = new ContentLoader();
await contentLoader.DownloadMultipleTaskAsync("https://learn.microsoft.com/ru-ru/dotnet/csharp/");
Console.WriteLine("Another jobs in main thread...");

await contentLoader.WaitForAsync("Панаc");
await contentLoader.WaitForAsync("Yurko");
await contentLoader.WaitForAsync("Ignat");

var forDima = contentLoader.WaitForAsync("Dima");
var forKirill = contentLoader.WaitForAsync("Kirill");
var forMaksym = contentLoader.WaitForAsync("Maksym");

await forDima;
await forKirill;
await forMaksym;

contentLoader.delayedPrinter("hello world");
contentLoader.delayedPrinter("What`s the weather?");


Console.WriteLine("\n Program done");
Console.ReadLine();