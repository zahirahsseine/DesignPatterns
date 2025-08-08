public class BookCollection : IEnumerable<Book>
{
    private List<Book> books = new();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // This is the Iterator part
    public IEnumerator<Book> GetEnumerator()
    {
        foreach (var book in books)
            yield return book;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
