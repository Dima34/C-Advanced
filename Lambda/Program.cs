List<Book> books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(IsCheaper10Dollars);

static bool IsCheaper10Dollars(Book book)
{
    return book.Price < 10;
}

Console.WriteLine(cheapBooks.Count);
