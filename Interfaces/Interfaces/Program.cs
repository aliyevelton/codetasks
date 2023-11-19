using Interfaces;
using Interfaces.Exceptions;

Book book1 = new Book("Book1", "Author1", 100);
Book book2 = new Book("Book2", "Author2", 200);
Book book3 = new Book("Book3", "Author3", 300);
Book book4 = new Book("Book4", "Author4", 400);

Console.WriteLine(book1 < book2);

Library library = new Library(4);



try
{
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);

    Console.WriteLine(library.GetBookById(2));

}
catch(CapacityLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch(AlreadyExistsException ex)
{
    Console.WriteLine(ex.Message);
}
catch(NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

