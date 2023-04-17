
//
// var printTask = AsyncMethods.PrintAsync("Hello 1", 2000);
// var printTask2 = AsyncMethods.PrintAsync("Hello 2", 1500);
// var printTask3 = AsyncMethods.PrintAsync("Hello 3", 3000);
//
// Task.WaitAny(printTask, printTask2, printTask3);

var calcuationAsync = AsyncMethods.MultiplyAsync(4, 2);
var calcuationAsync1 = AsyncMethods.MultiplyAsync(2, 3);
var calcuationAsync2 = AsyncMethods.MultiplyAsync(3, 4);

var result = await Task.WhenAny(calcuationAsync, calcuationAsync1, calcuationAsync2);
// var result = await Task.WhenAll(calcuationAsync, calcuationAsync1, calcuationAsync2);

Console.WriteLine("End of proram");
Console.ReadLine();