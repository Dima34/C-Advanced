´public class Book
{
    public int Price { get; set; }
    public string Title { get; set; }
}

public class BookRepository
{
    private List<Book> _repository = new List<Book>()
    {
        new Book(){ Title = "The saga of Isaac", Price = 12},
        new Book(){ Title = "Kolobol", Price = 1},
        new Book(){ Title = "The Fox story", Price = 20},
        new Book(){ Title = "Bible", Price = 100},
    };

    public List<Book> GetBooks()
    {
        return _repository;
    }
}