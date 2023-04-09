
try
{
    var divideResult = Divide(5, 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You are trying to divide by zero");
}
catch
{
    Console.WriteLine("Sorry, error happend");
}

Console.WriteLine("End of program");

float Divide(int a, int b)
{
    return a / b;
}