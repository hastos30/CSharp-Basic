using System.Net.NetworkInformation;

namespace Classes;

public class Libraty
{
    private Book[] _books = null;

    public int BooksCount
    {
        get
        {
            return Books.Length;
        }
    }

    public void FillLibrary()
    {
        _books = new Book[]
        {
            new Book("CLR via C#")
            {
                Author = "Jeffrey Richter"
            },
            new Book("Code Complete")
            {
                Author = "Steve McConnell"
            },
            new Book("Windows Runtime Via C#")
            {
                Author = "Jeffrey Richter"
            },
        };
    }

    public Book FindBookByTitle(string name)
    {
        foreach (var book in Books)
        {
            if (book.Title.StartsWith(name))
            {
                return book;
            }
        }

        return null;
    }

    public Book[] FindBooksByAuthor(string name)
    {
        List<Book> foundBooks = new List<Book>();

        foreach (var book in Books)
        {
            if (book.Author.StartsWith(name))
            {
                foundBooks.Add(book);
            }
        }

        return foundBooks.ToArray();
    }

    private Book[] Books
    {
        get
        {
            if (_books == null)
            {
                return new Book[0];
            }

            return _books;
        }
    }
}