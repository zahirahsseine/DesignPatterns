 var collection = new BookCollection();
 collection.AddBook(new Book("Design Patterns"));
 collection.AddBook(new Book("Clean Code"));
 collection.AddBook(new Book("Refactoring"));

 foreach (var book in collection)
{
    Console.WriteLine(book.Title);
}
