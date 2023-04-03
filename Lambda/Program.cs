List<Book> books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(b => b.Price < 10);

static bool IsCheaper10Dollars(Book book)
{
    return book.Price < 10;
}

Console.WriteLine(cheapBooks.Count);
