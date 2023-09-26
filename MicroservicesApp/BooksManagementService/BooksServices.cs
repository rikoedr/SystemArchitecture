namespace MicroservicesApp.BooksManagementService;

public class BooksServices
{
    List<Book> books = new List<Book>();

    public List<object> GetBooks()
    {
        List<object> result = new List<object>();

        foreach (Book item in books)
        {
            result.Add(item);
        }

        return result;
    }

    public List<string> GetByID(string isbn)
    {
        int index = books.FindIndex(item => item.ISBN == isbn);

        if (index < 0)
        {
            return new List<string>();
        }

        return new List<string>
        {
            books[index].ISBN,
            books[index].Title,
            books[index].Author
        };
    }



    public string Add(string isbn, string title, string author)
    {
        books.Add(new Book
        {
            ISBN = isbn,
            Title = title,
            Author = author
        });

        return "Add success!";
    }

    public string Edit(string isbn, string title, string author)
    {
        int index = books.FindIndex(item => item.ISBN == isbn);

        if (index < 0)
        {
            return "Edit failed. Book not found!";
        }

        books[index].Title = title;
        books[index].Author = author;

        return "Edit success!";
    }

    public string DeleteBook(string isbn)
    {
        int index = books.FindIndex(item => item.ISBN == isbn);

        if (index < 0)
        {
            return "Delete failed. Book not found!";

        }

        books.RemoveAt(index);

        return "Delete success";
    }
}