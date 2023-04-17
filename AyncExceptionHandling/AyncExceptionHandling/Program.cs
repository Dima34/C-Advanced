// try
// {
//     await AsyncOperations.PrintAsyncTask("123");
// }
// catch (Exception e)
// {
//     Console.WriteLine($"Сaught exeption. Message: {e.Message}");
// }

// AsyncOperations.PrintAsyncVoid("He");

var asyncTask1 = AsyncOperations.PrintAsyncTask("1235");
var asyncTask2 = AsyncOperations.PrintAsyncTask("123");
var asyncTask3 = AsyncOperations.PrintAsyncTask("123");

var allTasks =  Task.WhenAll(asyncTask1, asyncTask2, asyncTask3);

try
{
    await allTasks; 
}
catch (Exception e)
{ 
    Console.WriteLine(e);

    if (allTasks.Exception != null)
    {
        foreach (var exceptionInnerException in allTasks.Exception.InnerExceptions)
        {
            Console.WriteLine("Inner exception: " + exceptionInnerException);
        }
    }
}

Console.ReadLine();