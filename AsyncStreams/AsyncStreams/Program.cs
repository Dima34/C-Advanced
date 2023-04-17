
// const int ITERATION_COUNT = 10;
//
// async IAsyncEnumerable<int> GetNumbersAsync()
// {
//     for (int i = 0; i < ITERATION_COUNT; i++)
//     {
//         Console.WriteLine($"Start Awaiting {i} number");
//         await Task.Delay(1000);
//         yield return i;
//     }
// }

using System.Security.AccessControl;

async Task<int> MathOperation(int a, int b,  OperationType operationType)
{
    await Task.Delay(a * 100);
    switch (operationType)
    {
        case OperationType.Multiplication:
            return a * b;
        case OperationType.Substracition:
            return a - b;
        case OperationType.Division:
            return a / b;
        default:
            return a + b;
    }
}

async IAsyncEnumerable<int> CalculationStreamAsync(params MathOperation[] mathOperations)
{
    for (var i = 0; i < mathOperations.Length; i++)
    {
        var operation = mathOperations[i];
        var task = await  MathOperation(operation.A, operation.B, operation.OperationType);
        yield return task;
    }
}

var asyncEnumerable = CalculationStreamAsync(
    new MathOperation(4,3,OperationType.Division),
    new MathOperation(2,4, OperationType.Multiplication), 
    new MathOperation(6,7, OperationType.Addition), 
    new MathOperation(9,10, OperationType.Substracition));

await foreach (var number in asyncEnumerable)
{
    Console.WriteLine($"Result is {number}");
}


Console.ReadLine();

class MathOperation
{
    public int A { get; set; }
    public int B { get; set; }
    public OperationType OperationType { get; set; }

    public MathOperation(int a, int b, OperationType  operationType)
    {
        A = a;
        B = b;
        OperationType = operationType; 
    }
}

public enum OperationType
{
    Addition = 0,
    Substracition = 1,
    Multiplication = 2,
    Division = 3
}