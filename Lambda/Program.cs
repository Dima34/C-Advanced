List<Book> books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(b => b.Price < 10);

static bool IsCheaper10Dollars(Book book)
{
    return book.Price < 10;
}

Console.WriteLine(cheapBooks.Count);

float Multiply(float a, float b) => a * b;
float Addition(float a, float b) => a + b;

float Operatings(float a, float b, Func<float, float, float> func) => func(a, b);

Console.WriteLine($"Multiply 2*3={Operatings(2,3,Multiply)}");
Console.WriteLine($"Addition 2+3={Operatings(2,3,Addition)}");

Console.ReadLine();
