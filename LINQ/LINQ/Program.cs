List<Book> bookList = new List<Book>()
{
    new Book(){Title = "Lev tolstoy", Price = 10},
    new Book(){Title = "Vinny Puh", Price = 15},
    new Book(){Title = "Iskustvo pofigizma", Price = 20},
    new Book(){Title = "Karl Marks", Price = 7},
    new Book(){Title = "Bible", Price = 200}
};

var cheaperBooks = from b in bookList
    where b.Price < 10
    orderby b.Title
    select b;
// The same as 
var cheapBooks = 
    bookList.Where(b => b.Price < 10)
    .OrderBy(b => b.Title)
    .Select(b => b);
    
var last2 = bookList.Skip(2).Take(3);
Console.WriteLine(last2);

DateTime date = null;

Console.ReadLine();
