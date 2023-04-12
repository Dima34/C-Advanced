using System.Collections;

var contentLoader = new ContentLoader();
await contentLoader.DownloadMultipleTaskAsync("https://learn.microsoft.com/ru-ru/dotnet/csharp/");
Console.WriteLine("Another jobs in main thread...");

// await contentLoader.WaitForAsync("Панаc");
// await contentLoader.WaitForAsync("Yurko");
// await contentLoader.WaitForAsync("Ignat");
//
// var forDima = contentLoader.WaitForAsync("Dima");
// var forKirill = contentLoader.WaitForAsync("Kirill");
// var forMaksym = contentLoader.WaitForAsync("Maksym");
//
// await forDima;
// await forKirill;
// await forMaksym;

// contentLoader.delayedPrinter("hello world");
// contentLoader.delayedPrinter("What`s the weather?");

Action SomeEvent = EventReaction;
SomeEvent?.Invoke();

async void EventReaction()
{
    await Task.Delay(3000);
    Console.WriteLine("Wooow sheesh! That event done 3 minutes ago!");
}


async Task<int> CalculateTheHardestExpressionEver()
{
    Console.WriteLine("Calculating hardest expression ever...");
    Task.Delay(5000);
    return 2 + 2;
}

var HardestEverResult = CalculateTheHardestExpressionEver();
Console.WriteLine($"The hardest result is {HardestEverResult.Result}");

Console.WriteLine("\n Program done");
Console.ReadLine();