public class Book
{
    public string Title { get; set; }
    public int Price { get; set; }

    public override string ToString() => $"{Title} - {Price}";
}